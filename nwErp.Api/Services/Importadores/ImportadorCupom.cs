using nwErp.Api.Importadores;
using System.Runtime.Caching;
using nwErp.Api.Entidades;
using nwErp.Api.Persistencia;
using System.Text;
using System.Net.Http.Headers;

namespace nwErp.Api;

public class ImportadorCupom : ImportadorBase
{
    public class DUAL
    {
        public string SID { get; set; }
    }

    private PCCONSUM _pcconsum = new PCCONSUM();

    private PCFILIAL _filial;

    private DateTime _dataProcessamento;

    private List<PCMOV> _movimentacoes = new List<PCMOV>();

    private List<PCPREST> _parcelas = new List<PCPREST>();

    private PCPEDC _pedido;

    private PCCLIENT _cliente;

    private PCNFSAID _nota;

    private decimal _numcar;

    private List<PCVERBA> _ListaVerba;

    private decimal[] numeroVerbas;

    private bool _vendaJaExistente;

    private bool _vendaOrcamento;

    private PCPEDC _pedidoExistente;

    private string SID;

    private decimal _valorRebaixaCMV;

    private readonly ObjectCache _cache = MemoryCache.Default;

    protected override void Importar()
    {
        base.Importar();
        CalcularPisCofins();
        logFat.Adicionar("Processo Finalizado");
        logFat.Gravar();
    }

    private bool ZeraNumCar()
    {
        if (_vendaJaExistente)
        {
            if (!((_pcconsum.Usanumcarvendabalcao == null) ? "N" : _pcconsum.Usanumcarvendabalcao).ToUpper().Equals("S") && _pedidoExistente != null && !string.IsNullOrEmpty(_pedidoExistente.Origemped) && (_pedidoExistente.Origemped.Equals("R") || _pedidoExistente.Origemped.Equals("B")))
            {
                return true;
            }
            return false;
        }
        return true;
    }

    protected override void TratarRegistros()
    {
        if (base.DefinicaoPedido.Pedido.Notadupliquesvc != null && base.DefinicaoPedido.Pedido.Notadupliquesvc.ToUpper().Contains("S"))
        {
            base.DefinicaoPedido.Pedido.Numped = null;
        }
        if (base.DefinicaoPedido.Pedido.Posicao != null && base.DefinicaoPedido.Pedido.Posicao != "D")
        {
            base.DefinicaoPedido.Pedido.Posicao = "F";
        }
        base.DefinicaoPedido.Pedido.Importado = "S";
        CarregarInformacoesGerais();
        GerarNumeracoes();
        base.TratarRegistros();
    }

    private void CarregarInformacoesGerais()
    {
        string cacheKeyClient = $"CODCLI{base.DefinicaoPedido.Pedido.Codcli.ToString()}";
        string cacheKeyFilial = $"CODFILIAL{base.DefinicaoPedido.Pedido.Codfilial}";
        CacheItemPolicy policy = new CacheItemPolicy
        {
            SlidingExpiration = new TimeSpan(2, 0, 0)
        };
        _pcconsum = ParametrosDoSistema.ObterParametros(base.Persistencia);
        if (!_cache.Contains(cacheKeyFilial))
        {
            _filial = base.Persistencia.CarregarLista(new PCFILIAL(), (PCFILIAL fil) => fil.Codigo == DefinicaoPedido.Pedido.Codfilial).First();
            _cache.Set(cacheKeyFilial, _filial, policy);
        }
        else
        {
            _filial = (PCFILIAL)_cache.Where((KeyValuePair<string, object> x) => x.Key.Equals(cacheKeyFilial)).First().Value;
            logFat.Adicionar($"INFORMAÇÃO CARREGADA DA MÉMORIA PCFILIAL CODIGO FILIAL:{_filial.Codigo} ");
        }
        if (!_cache.Contains(cacheKeyClient))
        {
            _cliente = base.Persistencia.CarregarLista(new PCCLIENT(), (PCCLIENT cli) => cli.Codcli == DefinicaoPedido.Pedido.Codcli).First();
            _cache.Set(cacheKeyClient, _cliente, policy);
        }
        else
        {
            _cliente = (PCCLIENT)_cache.Where((KeyValuePair<string, object> x) => x.Key.Equals(cacheKeyClient)).First().Value;
            logFat.Adicionar($"INFORMAÇÃO CARREGADA DA MÉMORIA PCCLIENT CODIGO CLIENTE{_cliente.Codcli.ToString()} ");
        }
        _dataProcessamento = base.Persistencia.DataHoraAtual();
    }

    private void CalcularPisCofins()
    {
        logFat.Adicionar("INICIO - CalcularPisCofins");
        if (base.DefinicaoPedido.Pedido.Docemissao != null && (base.DefinicaoPedido.Pedido.Docemissao == "SF" || base.DefinicaoPedido.Pedido.Docemissao == "MF"))
        {
            return;
        }
        try
        {
            FISCAL.CALCULARPISCOFINS_VENDA cALCULARPISCOFINS_VENDA = new FISCAL.CALCULARPISCOFINS_VENDA();
            cALCULARPISCOFINS_VENDA.NUMTRANSACAO = base.DefinicaoPedido.Pedido.Numtransvenda.GetValueOrDefault(0m);
            if (cALCULARPISCOFINS_VENDA.NUMTRANSACAO > 0m && base.Persistencia.ProcedureValidaExiste(cALCULARPISCOFINS_VENDA))
            {
                base.Persistencia.ExecutarProcedure(cALCULARPISCOFINS_VENDA);
            }
        }
        catch
        {
        }
        logFat.Adicionar("FIM    - CalcularPisCofins");
    }

    protected override void ExecutarProcessosAdicionaisEFinalizar()
    {
        logFat.Adicionar($"-> Thread: {Thread.CurrentThread.ManagedThreadId}.");
        try
        {
            logFat.Adicionar("Iniciando Processo");
            SID = base.Persistencia.ConsultaPorSQL<DUAL>("SELECT SYS_CONTEXT('USERENV','SID') SID FROM DUAL").FirstOrDefault().SID;
            logFat.Adicionar($"THREAD {Thread.CurrentThread.ManagedThreadId} - TRANSAÇÃO COM O NUMERO DE SID: {SID}");
            GerarItensDePedido();
            GerarCabecalho();
            PrepararPedidoOrigem316();
            GerarParcelas();
            GerarInformacoesDeConsumidorFinal();
            GerarDocumentoEletronico();
            GerarOrigemDePrecos();
            GerarCabelhoDaNota();
            GerarInformacoesDeTributacao();
            EfetuarBaixaDeEstoque();
            GerarCancelamentoWTA();
        }
        catch (Exception ex)
        {
            logFat.GravarExcecao(ex);
            throw ex;
        }
        base.ExecutarProcessosAdicionaisEFinalizar();
    }

    private void GerarCabecalho()
    {
        logFat.Adicionar("INICIO - GerarCabecalho");
        RegistrarLog("Gerando cabecalho de pedido");
        _pedido = new PCPEDC();
        _pedido.Rotina = "nwErp.exe";
        logFat.Adicionar("INICIO - BuscarSimilaridade");
        _pedido.BuscarSimilaridade(base.DefinicaoPedido.Pedido);
        logFat.Adicionar("FIM    - BuscarSimilaridade");
        RegistrarLog("Numtransvenda: " + _pedido.Numtransvenda);
        _pedido.Operacao = "N";
        _pedido.Importacupom = 1;
        _pedido.Numviasmapasep = 1;
        _pedido.Percvenda = 100;
        _pedido.Condvenda = 1;
        if (_valorRebaixaCMV > 0m)
        {
            PCPEDC pedido = _pedido;
            pedido.Vlcustofin -= (decimal?)_valorRebaixaCMV;
            PCPEDC pedido2 = _pedido;
            pedido2.Vlcustoreal -= (decimal?)_valorRebaixaCMV;
        }
        _pedido.Dtfat = base.DefinicaoPedido.Pedido.Data;
        if (base.DefinicaoPedido.Pedido.Horacupom.Length > 1 && base.DefinicaoPedido.Pedido.Horacupom.Contains(":"))
        {
            _pedido.Horafat = Convert.ToDecimal(base.DefinicaoPedido.Pedido.Horacupom.Split(':')[0]);
            _pedido.Minutofat = Convert.ToDecimal(base.DefinicaoPedido.Pedido.Horacupom.Split(':')[1]);
        }
        if (base.DefinicaoPedido.Pedido.Posicao == "D")
        {
            _pedido.Posicao = "F";
        }
        decimal? numpedcanc = base.DefinicaoPedido.Pedido.Numpedcanc;
        if ((numpedcanc.GetValueOrDefault() > default(decimal)) & numpedcanc.HasValue)
        {
            logFat.Adicionar("INICIO    - Procedimento Numpedcanc");
            PCPEDC pCPEDC = base.Persistencia.CarregarLista(new PCPEDC(), (PCPEDC x) => new { x.Numpedecf, x.Numcaixa, x.Numserieequip, x.Numcupom, x.Numped }, (PCPEDC x) => (decimal?)x.Numped == DefinicaoPedido.Pedido.Numpedcanc).FirstOrDefault();
            if (pCPEDC != null && pCPEDC != null)
            {
                decimal? numcupom = (pCPEDC.Numcaixa = (pCPEDC.Numpedecf = null));
                pCPEDC.Numserieequip = "";
                pCPEDC.Numcupom = numcupom;
                base.Persistencia.Persistir(TipoPersistencia.ALTERAR, pCPEDC);
            }
            logFat.Adicionar("FIM    - Procedimento Numpedcanc");
        }
        if (!_vendaJaExistente)
        {
            _pedido.Origemped = "A";
            base.Persistencia.Persistir(TipoPersistencia.INCLUIR, _pedido);
        }
        logFat.Adicionar("FIM    - GerarCabecalho");
    }

    private void GerarParcelas()
    {
        logFat.Adicionar("INICIO - GerarParcelas");
        if (base.DefinicaoPedido.Parcelas.Count > 0)
        {
            RegistrarLog("Gerando parcelas");
        }
        int num = 1;
        bool flag = false;
        decimal? num2 = base.DefinicaoPedido.Itens.Select((PCPEDIECF i) => i.Qt * i.Percom.GetValueOrDefault(0m) * i.Pvenda / 100m).Sum();
        num2 = ((!(num2.GetValueOrDefault(0m) == 0m)) ? (num2 / (decimal?)base.DefinicaoPedido.Pedido.Vltotal.GetValueOrDefault(1m) * (decimal?)100) : new decimal?(default(decimal)));
        foreach (PCPRESTECF parcela in base.DefinicaoPedido.Parcelas)
        {
            PCPREST pCPREST = new PCPREST();
            logFat.Adicionar("INICIO - BuscarSimilaridade");
            pCPREST.BuscarSimilaridade(parcela);
            logFat.Adicionar("FIM    - BuscarSimilaridade");
            pCPREST.Dtemissaoorig = pCPREST.Dtemissao;
            if (string.IsNullOrEmpty(parcela.Prestecf) || parcela.Prestecf == "0")
            {
                pCPREST.Prest = num.ToString();
            }
            else
            {
                pCPREST.Prest = parcela.Prestecf;
            }
            pCPREST.Valorliqcom = parcela.Valor;
            pCPREST.Vltxboleto = parcela.Vltxboleto;
            pCPREST.Codusur2 = parcela.Codusur2;
            pCPREST.Operacao = "N";
            pCPREST.Status = "A";
            pCPREST.Percom = num2;
            pCPREST.Rotinalanc = 2075;
            if (_vendaJaExistente && base.DefinicaoPedido.Pedido.Numcar.GetValueOrDefault(0m) != 0m)
            {
                PCCLIENT pCCLIENT = base.Persistencia.CarregarLista(new PCCLIENT(), (PCCLIENT cli) => cli.Codcli == _pedidoExistente.Codcli).FirstOrDefault();
                if (pCCLIENT.Perdescfin.GetValueOrDefault(0m) > 0m)
                {
                    pCPREST.Perdesc = pCCLIENT.Perdescfin.GetValueOrDefault(0m);
                    pCPREST.Valordesc = parcela.Valor * (pCCLIENT.Perdescfin.GetValueOrDefault(0m) / 100m);
                }
            }
            if (ZeraNumCar())
            {
                pCPREST.Numcar = default(decimal);
            }
            else if (_vendaJaExistente)
            {
                if (((_pcconsum.Usanumcarvendabalcao == null) ? "N" : _pcconsum.Usanumcarvendabalcao).ToUpper().Equals("S"))
                {
                    pCPREST.Numcar = _numcar;
                }
                if (_pedidoExistente != null && _pedidoExistente.Origemped != null)
                {
                    _ = _pedidoExistente.Numcar;
                    if (_pedidoExistente.Origemped.Equals("T"))
                    {
                        pCPREST.Numcar = _numcar;
                    }
                }
            }
            if (!pCPREST.Numcar.HasValue)
            {
                pCPREST.Numcar = default(decimal);
            }
            if (parcela.Codcob == "CRED")
            {
                pCPREST.Codfunccxmot = parcela.Codfunccheckout;
                pCPREST.Dtcxmot = _dataProcessamento;
                pCPREST.Dtpag = pCPREST.Dtcxmot;
                pCPREST.Dtultalter = pCPREST.Dtcxmot;
                pCPREST.Vpago = parcela.Valor;
                pCPREST.Dtfecha = pCPREST.Dtemissao;
                pCPREST.Dtbaixa = base.Persistencia.UltimaDataHora;
                pCPREST.Codbaixa = parcela.Codfunccheckout;
                pCPREST.Codfuncfecha = parcela.Codfunccheckout;
                flag = true;
            }
            else
            {
                pCPREST.Codfunccxmot = null;
                pCPREST.Dtcxmot = null;
                pCPREST.Dtpag = null;
                pCPREST.Dtultalter = null;
                pCPREST.Vpago = null;
            }
            pCPREST.Hubnumcaixapadrao = parcela.Hubnumcaixapadrao;
            base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCPREST);
            _parcelas.Add(pCPREST);
            num++;
        }
        FecharCarregamento();
        logFat.Adicionar("FIM    - GerarParcelas");
    }

    private void FecharCarregamento()
    {
        logFat.Adicionar("INICIO - FecharCarregamento");
        if (_pedidoExistente != null && _pcconsum.Fechacarregautvendabalcao.Equals("S") && _pedidoExistente.Numcar > 0m && _pedidoExistente.Numcar != 0m && _pedidoExistente.Origemped != "T" && _pedidoExistente.Origemped != "F" && base.Persistencia.CarregarLista(new PCPEDC(), (PCPEDC p) => p.Numcar == _pedidoExistente.Numcar && p.Posicao != "F").Count == 0)
        {
            List<PCCARREG> list = base.Persistencia.CarregarLista(new PCCARREG(), (PCCARREG p) => p.Dtfecha, (PCCARREG p) => p.Numcar == _pedidoExistente.Numcar);
            if (list != null)
            {
                foreach (PCCARREG item in list)
                {
                    item.Dtfecha = DateTime.Now.Date;
                    base.Persistencia.Persistir(TipoPersistencia.ALTERAR, item);
                }
            }
        }
        logFat.Adicionar("FIM   - FecharCarregamento");
    }

    private void PrepararPedidoOrigem316()
    {
        logFat.Adicionar("INICIO - PrepararPedidoOrigem316");
        decimal numPed = base.DefinicaoPedido.Pedido.Numped.GetValueOrDefault();
        if (_vendaJaExistente)
        {
            logFat.Adicionar("INICIO - CARREGAR LISTA PCPEDC");
            _pedidoExistente = base.Persistencia.CarregarLista(new PCPEDC(), (PCPEDC pcped) => pcped.Numped == numPed).FirstOrDefault();
            logFat.Adicionar("FIM    - CARREGAR LISTA PCPEDC");
            if (_pedidoExistente != null)
            {
                _ = _pedidoExistente.Numped;
                _pedidoExistente.Versaofaturamento = base.DefinicaoPedido.Pedido.Versaofaturamento;
                _pedidoExistente.Numtransvenda = base.DefinicaoPedido.Pedido.Numtransvenda.GetValueOrDefault();
                _pedidoExistente.Posicao = "F";
                _pedidoExistente.Numpedecf = base.DefinicaoPedido.Pedido.Numpedecf;
                _pedidoExistente.Codfunccx = base.DefinicaoPedido.Pedido.Codfunccx;
                _pedidoExistente.Serieecf = "X";
                _pedidoExistente.Versaorotina = base.DefinicaoPedido.Pedido.Versaorotina;
                if (string.IsNullOrEmpty(_pedidoExistente.Codfilialnf))
                {
                    _pedidoExistente.Codfilialnf = base.DefinicaoPedido.Pedido.Codfilial;
                }
                if (base.DefinicaoPedido.Pedido.Vlsubtotal.GetValueOrDefault(0m) > 0m)
                {
                    _pedidoExistente.Vlsubtotal = base.DefinicaoPedido.Pedido.Vlsubtotal;
                }
                _pedidoExistente.Dtmovimentocx = base.DefinicaoPedido.Pedido.Dtmovimentocx;
                _pedidoExistente.Numfechamentomovcx = base.DefinicaoPedido.Pedido.Numfechamentomovcx;
                _pedidoExistente.Dtfat = base.DefinicaoPedido.Pedido.Data;
                if (base.DefinicaoPedido.Pedido.Horacupom.Length > 0)
                {
                    _pedidoExistente.Horafat = Convert.ToDecimal(base.DefinicaoPedido.Pedido.Horacupom.Split(':')[0]);
                    _pedidoExistente.Minutofat = Convert.ToDecimal(base.DefinicaoPedido.Pedido.Horacupom.Split(':')[1]);
                }
                _pedidoExistente.Protocolonfce = base.DefinicaoPedido.Pedido.Protocolonfce;
                _pedidoExistente.Chavenfce = base.DefinicaoPedido.Pedido.Chavenfce;
                _pedidoExistente.Docemissao = base.DefinicaoPedido.Pedido.Docemissao;
                base.Persistencia.Persistir(TipoPersistencia.ALTERAR, _pedidoExistente);
                logFat.Adicionar("INICIO - CARREGAR LISTA PCVENDACONSUM");
                PCVENDACONSUM pCVENDACONSUM = base.Persistencia.CarregarLista(new PCVENDACONSUM(), (PCVENDACONSUM c) => c.Numped == _pedidoExistente.Numped).FirstOrDefault();
                logFat.Adicionar("FIM    - CARREGAR LISTA PCVENDACONSUM");
                if (pCVENDACONSUM != null && pCVENDACONSUM != null && base.DefinicaoPedido.ConsumidorFinal.Where((PCVENDACONSUMECF p) => p.Cgcent != null && p.Cgcent != "").Count() > 0)
                {
                    pCVENDACONSUM.Cgcent = base.DefinicaoPedido.ConsumidorFinal[0].Cgcent;
                    base.Persistencia.Persistir(TipoPersistencia.ALTERAR, pCVENDACONSUM);
                }
            }
            logFat.Adicionar("INICIO - CARREGAR LISTA PCPEDI");
            List<PCPEDI> list = base.Persistencia.CarregarLista(new PCPEDI(), (PCPEDI item) => new { item.Codauxiliar, item.Numseq }, (PCPEDI pcpedi) => pcpedi.Numped == numPed);
            logFat.Adicionar("FIM    - CARREGAR LISTA PCPEDI");
            logFat.Adicionar("INICIO - LOOP PCPEDI");
            foreach (PCPEDI itemExistente in list)
            {
                itemExistente.Posicao = "F";
                PCPEDIECF pCPEDIECF = base.DefinicaoPedido.Itens.Where(delegate (PCPEDIECF i)
                {
                    if (i.Codauxiliar == itemExistente.Codauxiliar)
                    {
                        decimal? numseqorig = i.Numseqorig;
                        decimal numseq = itemExistente.Numseq;
                        return (numseqorig.GetValueOrDefault() == numseq) & numseqorig.HasValue;
                    }
                    return false;
                }).FirstOrDefault();

                if (pCPEDIECF != null && pCPEDIECF != null)
                {
                    itemExistente.Qt = pCPEDIECF.Qt;
                    itemExistente.Pvenda = pCPEDIECF.Pvenda;
                    itemExistente.Vlsubtotitem = pCPEDIECF.Vlsubtotitem;
                    itemExistente.Vlipiecf = pCPEDIECF.Vlipiecf;
                    itemExistente.Codst = pCPEDIECF.Codst;

                    if (pCPEDIECF.Brinde == "S")
                    {
                        itemExistente.Pbonific = pCPEDIECF.Pvenda;
                    }
                }
                base.Persistencia.Persistir(TipoPersistencia.ALTERAR, itemExistente);
            }
            logFat.Adicionar("FIM    - LOOP PCPEDI");
        }
        logFat.Adicionar("FIM    - PrepararPedidoOrigem316");
    }

    private void GerarItensDePedido()
    {
        logFat.Adicionar("INICIO - GerarItensDePedido");
        if (base.DefinicaoPedido.Itens.Count > 0)
        {
            logFat.Adicionar($"GerarItensDePedido, Quantidade de Itens: {base.DefinicaoPedido.Itens.Count.ToString()} **");
        }
        if (!base.DefinicaoPedido.Pedido.Posicao.Equals("D"))
        {
            logFat.Adicionar("INICIO - Carregar Listagem de VERBA para Aplicação");
            _ListaVerba = base.Persistencia.CarregarLista(new PCVERBA(), (PCVERBA v) => new { v.Numverba }, (PCVERBA verba) => verba.Codfilial == _filial.Codigo && verba.Dtapuracao == null && verba.Codconta == _pcconsum.Codcontarebaixacmvaapurar && verba.Dtcancel == null);
            numeroVerbas = _ListaVerba.Select((PCVERBA verba) => verba.Numverba).Distinct().ToArray();
            logFat.Adicionar("FIM    - Carregar Listagem de VERBA para Aplicação, Quantidade: " + numeroVerbas.Count());
        }
        if (_vendaJaExistente)
        {
            logFat.Adicionar("INICIO - CARREGAR LISTA PCPEDC");
            decimal numped = base.DefinicaoPedido.Pedido.Numped.GetValueOrDefault();
            _numcar = base.Persistencia.CarregarLista(new PCPEDC(), (PCPEDC pcped) => pcped.Numped == numped).FirstOrDefault()?.Numcar ?? 0m;
            logFat.Adicionar("FIM    - CARREGAR LISTA PCPEDC");
        }
        foreach (PCPEDIECF item in base.DefinicaoPedido.Itens)
        {
            logFat.Adicionar($"INICIO - LOOP PEDIDOS, Iniciando Item numseq: {item.Numseq.ToString()}");
            PCPEDI pCPEDI = new PCPEDI();
            logFat.Adicionar("INICIO - BuscarSimilaridade");
            pCPEDI.BuscarSimilaridade(item);
            logFat.Adicionar("FIM    - BuscarSimilaridade");
            pCPEDI.Codigobrinde = item.Codcampanha;
            if (item.Brinde == "S")
            {
                pCPEDI.Pbonific = item.Pvenda;
            }
            if (!_vendaJaExistente)
            {
                logFat.Adicionar("INICIO - INSERIR PCPEDI");
                base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCPEDI);
                logFat.Adicionar("FIM    - INSERIR PCPEDI");
            }
            else
            {
                logFat.Adicionar("INICIO - CarregarLista PCPEDI");
                PCPEDI pCPEDI2 = base.Persistencia.CarregarLista(new PCPEDI(), (PCPEDI p) => p.Codauxiliar == item.Codauxiliar && p.Numseq == item.Numseq && (decimal?)p.Numped == DefinicaoPedido.Pedido.Numped).FirstOrDefault();
                logFat.Adicionar("FIM    - CarregarLista PCPEDI");
                if (pCPEDI2 != null && pCPEDI2 != null)
                {
                    decimal? vlsubtotitem = item.Vlsubtotitem;
                    if ((vlsubtotitem.GetValueOrDefault() <= default(decimal)) & vlsubtotitem.HasValue)
                    {
                        item.Vlsubtotitem = null;
                    }
                    else
                    {
                        pCPEDI2.Vlsubtotitem = item.Vlsubtotitem;
                    }
                }
            }
            GerarMovimentacao(item, pCPEDI);
            logFat.Adicionar($"FIM    - LOOP PEDIDOS, Iniciando Item numseq: {item.Numseq.ToString()}");
        }
        logFat.Adicionar("FIM    - GerarItensDePedido");
    }

    private void GerarInformacoesDeConsumidorFinal()
    {
        logFat.Adicionar("INICIO - GerarInformacoesDeConsumidorFinal");
        if (base.DefinicaoPedido.ConsumidorFinal.Count > 0)
        {
            RegistrarLog("Gerando informacoes de consumidor final");
        }
        if (_vendaJaExistente && base.Persistencia.ContarRegistros<PCVENDACONSUM>((PCVENDACONSUM c) => (decimal?)c.Numped == DefinicaoPedido.Pedido.Numped) > 0)
        {
            return;
        }
        foreach (PCVENDACONSUMECF item in base.DefinicaoPedido.ConsumidorFinal.Where((PCVENDACONSUMECF p) => (p.Cgcent != null && p.Cgcent != "") || p.Identificacao_estrangeiro != ""))
        {
            PCVENDACONSUM pCVENDACONSUM = new PCVENDACONSUM();
            pCVENDACONSUM.BuscarSimilaridade(item);
            base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCVENDACONSUM);
        }
        logFat.Adicionar("FIM    - GerarInformacoesDeConsumidorFinal");
    }

    private void GerarNumeracoes()
    {
        PCUSUARI pCUSUARI = base.Persistencia.CarregarLista(new PCUSUARI(), (PCUSUARI usu) => usu.Codusur == DefinicaoPedido.Pedido.Codusur).FirstOrDefault();
        if (pCUSUARI != null)
        {
            _vendaJaExistente = base.DefinicaoPedido.Pedido.Numped.HasValue;
            if (!_vendaJaExistente)
            {
                decimal numeroPedido = base.Persistencia.ObterNumeroSequencialDeTabela(pCUSUARI, (PCUSUARI usu) => usu.Proxnumped);
                PCPEDC pCPEDC = base.Persistencia.CarregarLista(new PCPEDC(), (PCPEDC x) => x.Numped == numeroPedido).FirstOrDefault();
                if (pCPEDC != null && pCPEDC != null)
                {
                    throw new Exception($"Já existe um pedido com o numped: {numeroPedido} obtido do cadastro do Usuario: {base.DefinicaoPedido.Pedido.Codusur} **Verifique o cadastro da 517 na aba Numeradores, e ajuste o numerador Proximo número do Pedido!");
                }
                base.DefinicaoPedido.Pedido.Numped = numeroPedido;
            }
            _vendaOrcamento = base.DefinicaoPedido.Pedido.Numorca.GetValueOrDefault(0m) != 0m;
            decimal value = ObterNumeradores.ProxNumtransvenda(base.Persistencia);
            base.DefinicaoPedido.Pedido.Numtransvenda = value;
            return;
        }
        throw new Exception("Não foi encontrado o RCA para geração do numero de pedido");
    }

    private void GerarDocumentoEletronico()
    {
        logFat.Adicionar("INICIO - GerarDocumentoEletronico");
        if (base.DefinicaoPedido.DocumentoEletronico == null)
        {
            return;
        }
        if (base.DefinicaoPedido.DocumentoEletronico.Count > 0)
        {
            RegistrarLog("Gerando informacoes de consumidor final");
        }
        foreach (PCDOCELETRONICOECF item in base.DefinicaoPedido.DocumentoEletronico)
        {
            PCDOCELETRONICO pCDOCELETRONICO = new PCDOCELETRONICO();
            pCDOCELETRONICO.Numtransacao = base.DefinicaoPedido.Pedido.Numtransvenda.GetValueOrDefault(0m);
            pCDOCELETRONICO.Movimento = "S";
            pCDOCELETRONICO.Xmlnfce = item.Xmlnfce;
            base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCDOCELETRONICO);
        }
        logFat.Adicionar("FIM    - GerarDocumentoEletronico");
    }

    private void GerarOrigemDePrecos()
    {
        logFat.Adicionar("INICIO - GerarOrigemDePrecos");
        if (_vendaJaExistente)
        {
            return;
        }
        if (base.DefinicaoPedido.OrigemDePreco.Count > 0)
        {
            logFat.Adicionar("Gerando informacoes de origem de preco");
        }
        foreach (PCORIGEMPRECOECF item in base.DefinicaoPedido.OrigemDePreco)
        {
            item.Numped = base.DefinicaoPedido.Pedido.Numped;
            PCORIGEMPRECO pCORIGEMPRECO = new PCORIGEMPRECO();
            pCORIGEMPRECO.BuscarSimilaridade(item);
            base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCORIGEMPRECO);
        }
        logFat.Adicionar("FIM    - GerarOrigemDePrecos");
    }

    private decimal ObterEstoqueDisponivel(decimal Codprod)
    {
        try
        {
            logFat.Adicionar("INICIO - ObterEstoqueDisponivel");
            PKG_ESTOQUE.ESTOQUE_DISPONIVEL eSTOQUE_DISPONIVEL = new PKG_ESTOQUE.ESTOQUE_DISPONIVEL();
            eSTOQUE_DISPONIVEL.pnCODPROD = Codprod;
            eSTOQUE_DISPONIVEL.psCODFILIAL = base.DefinicaoPedido.Pedido.Codfilial;
            eSTOQUE_DISPONIVEL.psPROCESSO = "V";
            logFat.Adicionar("INICIO - ExecutarProcedure ESTOQUE_DISPONIVEL CODPROD: " + Codprod);
            base.Persistencia.ExecutarProcedure(eSTOQUE_DISPONIVEL);
            logFat.Adicionar("FIM    - ExecutarProcedure ESTOQUE_DISPONIVEL CODPROD: " + Codprod);
            logFat.Adicionar("FIM    - ObterEstoqueDisponivel, Retorno Procedure: " + eSTOQUE_DISPONIVEL.Retorno);
            return eSTOQUE_DISPONIVEL.Retorno;
        }
        catch (Exception)
        {
            throw new Exception(string.Format("*************" + Environment.NewLine + "ERRO PESQUISAR O ESTOQUE_DISPONIVEL NA PKG_ESTOQUE!, FAVOR EFETUAR A ATUALIZAÇÃO DA PKG_ESTOQUE NA ULTIMA VERSAO DISPONIVEL DA ROTINA 500." + Environment.NewLine + "LEMBRANDO QUE A VERSÃO DA ROTINA 500 DEVERÁ SEGUIR O VERSIONAMENTO DO SERVIDOR DE FATURAMENTO" + Environment.NewLine + "*************"));
        }
    }

    private void GerarMovimentacao(PCPEDIECF item, PCPEDI itemPedido)
    {
        logFat.Adicionar("INICIO - GerarMovimentacao");
        if (item.Tipomerc == "KT" || item.Tipomerc == "KA")
        {
            return;
        }
        bool num = base.DefinicaoPedido.ItensCesta.Where((PCPEDIECFCESTA prod) => prod.Codprod == item.Codprod).Count() > 0;
        PCMOV pCMOV = NovoItemDeMovimentacao();
        pCMOV.Codecf = item.Codecf;
        pCMOV.Punit = item.Pvenda;
        pCMOV.Qt = item.Qt;
        pCMOV.Codusur = item.Codusur;
        if (!num)
        {
            pCMOV.Tipoitem = "N";
            pCMOV.Qtcont = item.Qt;
            pCMOV.Punitcont = item.Pvenda;
            pCMOV.Status = "AB";
            pCMOV.Brinde = item.Brinde;
            pCMOV.Movestoquecontabil = "S";
            pCMOV.Movestoquegerencial = "S";
        }
        else
        {
            pCMOV.Tipoitem = "C";
            pCMOV.Qtcont = default(decimal);
            pCMOV.Punitcont = default(decimal);
            pCMOV.Status = "B";
            pCMOV.Movestoquecontabil = "N";
            pCMOV.Movestoquegerencial = "S";
        }
        pCMOV.Codprod = item.Codprod;
        logFat.Adicionar("INICIO - CarregarLista PCPRODFILIAL");
        PCPRODFILIAL pCPRODFILIAL = base.Persistencia.CarregarLista(new PCPRODFILIAL(), (PCPRODFILIAL f) => new { f.Geraicmslivrofiscal, f.Controlanumserie }, (PCPRODFILIAL f) => f.Codprod == item.Codprod && f.Codfilial == item.Codfilial).FirstOrDefault();
        if (ObterParametroString("CON_USATRIBENTPORUF", pCMOV.Codfilial) != "P")
        {
            logFat.Adicionar("CON_USATRIBENTPORUF != P");
            PCGERAICMSLIVROFISCALSAIDA pCGERAICMSLIVROFISCALSAIDA = base.Persistencia.CarregarLista(new PCGERAICMSLIVROFISCALSAIDA(), (PCGERAICMSLIVROFISCALSAIDA g) => new { g.Geraicmslivrofiscal }, (PCGERAICMSLIVROFISCALSAIDA pfilial) => pfilial.Codprod == item.Codprod && pfilial.Codfilial == item.Codfilial).FirstOrDefault();
            if (pCGERAICMSLIVROFISCALSAIDA != null)
            {
                if (pCGERAICMSLIVROFISCALSAIDA.Geraicmslivrofiscal == null)
                {
                    logFat.Adicionar("PCGERAICMSLIVROFISCALSAIDA.GERAICMSLIVROFISCAL NULO > GERAICMSLIVROFISCAL = S");
                    pCMOV.Geraicmslivrofiscal = "S";
                }
                else
                {
                    logFat.Adicionar("PCGERAICMSLIVROFISCALSAIDA.GERAICMSLIVROFISCAL PREENCHIDO");
                    pCMOV.Geraicmslivrofiscal = pCGERAICMSLIVROFISCALSAIDA.Geraicmslivrofiscal;
                }
            }
            else if (pCGERAICMSLIVROFISCALSAIDA == null || pCGERAICMSLIVROFISCALSAIDA == null)
            {
                logFat.Adicionar("NENHUM REGISTRO NA TABELA PCGERAICMSLIVROFISCALSAIDA > GERAICMSLIVROFISCAL = S");
                pCMOV.Geraicmslivrofiscal = "S";
            }
            else if (pCPRODFILIAL != null)
            {
                if (pCPRODFILIAL.Geraicmslivrofiscal == null)
                {
                    logFat.Adicionar("PRODFILIAL.GERAICMSLIVROFISCAL NULO > GERAICMSLIVROFISCAL = S");
                    pCMOV.Geraicmslivrofiscal = "S";
                }
                else
                {
                    logFat.Adicionar("PRODFILIAL.GERAICMSLIVROFISCAL PREENCHIDO");
                    pCMOV.Geraicmslivrofiscal = pCPRODFILIAL.Geraicmslivrofiscal;
                }
            }
            else if (pCPRODFILIAL == null || pCPRODFILIAL == null)
            {
                logFat.Adicionar("PRODFILIAL NAO TEM REGISTRO. GERAICMSLIVROFISCAL = S");
                pCMOV.Geraicmslivrofiscal = "S";
            }
            else
            {
                PCTRIBUT pCTRIBUT = base.Persistencia.CarregarLista(new PCTRIBUT(), (PCTRIBUT f) => new { f.Geraricmslivrofiscal }, (PCTRIBUT pTrib) => (decimal?)pTrib.Codst == item.Codst).FirstOrDefault();
                if (pCTRIBUT == null || pCTRIBUT.Geraricmslivrofiscal == null)
                {
                    logFat.Adicionar("TRIBUT.GERARICMSLIVROFISCAL NULO > GERAICMSLIVROFISCAL = S");
                    pCMOV.Geraicmslivrofiscal = "S";
                }
                else
                {
                    logFat.Adicionar("TRIBUT.GERARICMSLIVROFISCAL PREENCHIDO");
                    pCMOV.Geraicmslivrofiscal = pCTRIBUT.Geraricmslivrofiscal;
                }
            }
        }
        else if (ObterParametroString("CON_USATRIBENTPORUF", pCMOV.Codfilial) == "P")
        {
            logFat.Adicionar("INICIO - CarregarLista PCTRIBUT");
            PCTRIBUT pCTRIBUT2 = base.Persistencia.CarregarLista(new PCTRIBUT(), (PCTRIBUT f) => new { f.Geraricmslivrofiscal }, (PCTRIBUT pTrib) => (decimal?)pTrib.Codst == item.Codst).FirstOrDefault();
            logFat.Adicionar("FIM    - CarregarLista PCTRIBUT");
            if (pCTRIBUT2 == null || pCTRIBUT2.Geraricmslivrofiscal == null || pCTRIBUT2.Geraricmslivrofiscal == "N")
            {
                pCMOV.Geraicmslivrofiscal = "N";
            }
            else
            {
                pCMOV.Geraicmslivrofiscal = pCTRIBUT2.Geraricmslivrofiscal;
            }
        }
        decimal? numseqorig;
        if (_vendaJaExistente)
        {
            numseqorig = item.Numseqorig;
            if ((numseqorig.GetValueOrDefault() > default(decimal)) & numseqorig.HasValue)
            {
                pCMOV.Numseq = item.Numseqorig;
            }
        }
        pCMOV.Numseq = item.Numseq;
        pCMOV.Vlbasepiscofins = item.Vlbasepiscofins;
        pCMOV.Vlpis = item.Vlpis;
        pCMOV.Percofins = item.Percofins;
        pCMOV.Vlcofins = item.Vlcofins;
        pCMOV.Percdescpis = item.Percdescpis;
        pCMOV.Percdesccofins = item.Percdesccofins;
        pCMOV.Vldescreducaopis = item.Vldescreducaopis;
        pCMOV.Vldescreducaocofins = item.Vldescreducaocofins;
        pCMOV.Basedifaliquotas = item.Basedifaliquotas;
        pCMOV.Percdifaliquotas = item.Percdifaliquotas;
        pCMOV.Vldifaliquotas = item.Vldifaliquotas;
        pCMOV.Vlacrescrodape = item.Vlacrescrodape;
        pCMOV.Vldescrodape = item.Vldescrodape;
        pCMOV.Vldescfin = item.Vldescfin;
        pCMOV.Vloutrasdesp = item.Vloutrasdesp;
        pCMOV.Codauxiliar = item.Codauxiliar;
        pCMOV.Truncaritem = item.Truncaritem;
        pCMOV.Tipomerc = item.Tipomerc;
        numseqorig = item.Percbasered;
        pCMOV.Percbasered = (((numseqorig.GetValueOrDefault() == default(decimal)) & numseqorig.HasValue) ? new decimal?(100) : item.Percbasered);
        numseqorig = item.Percbaseredst;
        pCMOV.Percbaseredst = (((numseqorig.GetValueOrDefault() == default(decimal)) & numseqorig.HasValue) ? new decimal?(100) : item.Percbaseredst);
        pCMOV.Codsittribpiscofins = item.Codsittribpiscofins;
        pCMOV.Vldescicmisencao = item.Vldescicmisencao;
        pCMOV.Perdescisentoicms = item.Perdescisentoicms;
        pCMOV.Custoultent = item.Custoultent;
        pCMOV.Valorultent = item.Valorultent;
        pCMOV.Basebcr = item.Basebcr;
        pCMOV.Stbcr = item.Stbcr;
        pCMOV.Baseicmsbcr = item.Baseicmsbcr;
        pCMOV.Vlicmsbcr = item.Vlicmsbcr;
        pCMOV.Vldescsuframa = item.Vldescsuframa;
        pCMOV.Vlfrete = item.Vlfrete;
        pCMOV.Vldesconto = item.Vldescitem;
        pCMOV.Qbcmonoret = item.Qbcmonoret;
        pCMOV.Adremicmsret = item.Adremicmsret;
        pCMOV.Vicmsmonoret = item.Vicmsmonoret;
        if (ZeraNumCar())
        {
            pCMOV.Numcar = default(decimal);
        }
        else if (_vendaJaExistente)
        {
            if (((_pcconsum.Usanumcarvendabalcao == null) ? "N" : _pcconsum.Usanumcarvendabalcao).ToUpper().Equals("S"))
            {
                pCMOV.Numcar = _numcar;
            }
            if (_pedidoExistente != null && _pedidoExistente.Origemped != null)
            {
                _ = _pedidoExistente.Numcar;
                if (_pedidoExistente.Origemped.Equals("T"))
                {
                    pCMOV.Numcar = _numcar;
                }
            }
        }
        if (!pCMOV.Numcar.HasValue)
        {
            pCMOV.Numcar = default(decimal);
        }
        PCMOVCOMPLE pCMOVCOMPLE = new PCMOVCOMPLE();
        logFat.Adicionar("INICIO - BuscarSimilaridade");
        pCMOVCOMPLE.BuscarSimilaridade(item);
        logFat.Adicionar("FIM    - BuscarSimilaridade");
        pCMOVCOMPLE.Vlbaseipiecf = item.Baseipiecf;
        pCMOVCOMPLE.Vlicms = pCMOV.Baseicms * (pCMOV.Percicm / (decimal?)100);
        pCMOVCOMPLE.Vlicmsdesoneracao = item.Vlicmsdesoneracao;
        pCMOVCOMPLE.Codmotivoicmsdesonerado = item.Codmotivoicmsdesonerado;
        pCMOVCOMPLE.Aliqicms1ret = item.Aliqicms1;
        pCMOVCOMPLE.Perfcpstret = item.Perfcpstret;
        if (!string.IsNullOrEmpty(item.Excluiricmsbasepiscofins))
        {
            pCMOVCOMPLE.Excluiricmsbasepiscofins = item.Excluiricmsbasepiscofins;
        }
        if (itemPedido.Vlsubtotitem.HasValue)
        {
            decimal? vlsubtotitem = itemPedido.Vlsubtotitem;
            if ((vlsubtotitem.GetValueOrDefault() <= default(decimal)) & vlsubtotitem.HasValue)
            {
                pCMOVCOMPLE.Vlsubtotitem = null;
            }
        }
        pCMOVCOMPLE.Vlsubtotitem = itemPedido.Vlsubtotitem;
        if (item.Numseqorig.HasValue)
        {
            decimal? vlsubtotitem = item.Numseqorig;
            if (!((vlsubtotitem.GetValueOrDefault() <= default(decimal)) & vlsubtotitem.HasValue))
            {
                pCMOVCOMPLE.Numseqorig = item.Numseqorig;
            }
        }
        pCMOVCOMPLE.Numseqorig = null;

        if (!string.IsNullOrEmpty(item.Codfilialretira) && _vendaJaExistente)
        {
            pCMOV.Codfilialretira = item.Codfilialretira;
        }
        pCMOV.Ptabela = item.Ptabela;
        pCMOV.Pbaserca = item.Pbaserca;
        if (item.Brinde == "S")
        {
            pCMOV.Pbonific = item.Pvenda;
        }
        pCMOV.Numverbarebcmv = itemPedido.Numverbarebcmv;
        pCMOV.Vlverbacmv = itemPedido.Vlverbacmv;
        if (ObterParametroPorFilial("USAPRODUCAOSOBDEMANDA") && ProdutoEhAcabado(itemPedido.Codprod))
        {
            logFat.Adicionar("INICIO - CarregarLista PCEST");
            PCEST pCEST = base.Persistencia.CarregarLista(new PCEST(), (PCEST e) => e.Codfilial == _filial.Codigo && e.Codprod == itemPedido.Codprod).FirstOrDefault();
            logFat.Adicionar("FIM    - CarregarLista PCEST");
            pCMOV.Custocont = pCEST.Custocont.GetValueOrDefault(0m);
            pCMOV.Custofin = pCEST.Custofin.GetValueOrDefault(0m);
            pCMOV.Custoreal = pCEST.Custoreal.GetValueOrDefault(0m);
            pCMOV.Custoultent = pCEST.Custoultent.GetValueOrDefault(0m);
            pCMOV.Custorep = pCEST.Custorep.GetValueOrDefault(0m);
        }
        else
        {
            pCMOV.Custofin = itemPedido.Vlcustofin;
            pCMOV.Custoreal = itemPedido.Vlcustoreal;
            pCMOV.Custofinest = item.Custofinest;
            pCMOV.Custocont = item.Vlcustocont;
            pCMOV.Custorep = item.Vlcustorep;
        }
        pCMOV.Codicmtab = item.Codicmtab;
        pCMOV.St = item.St;
        pCMOV.Iva = item.Iva;
        pCMOV.Pauta = item.Pauta;
        pCMOV.Aliqicms1 = item.Aliqicms1;
        pCMOV.Aliqicms2 = item.Aliqicms2;
        pCMOV.Baseicst = item.Baseicst;
        pCMOV.Sittribut = item.Sittribut;
        pCMOV.Codfiscal = item.Codfiscal;
        pCMOV.Percicm = item.Percicm;
        pCMOV.Percdesc = item.Perdesc;
        pCMOV.Vlbaseipi = item.Vlbaseipi;
        pCMOV.Percipi = item.Percipi;
        pCMOV.Vlipi = item.Vlipi;
        pCMOV.Codst = item.Codst;
        pCMOV.Percom = item.Percom;
        if (base.DefinicaoPedido.Pedido.Docemissao == "CE" || base.DefinicaoPedido.Pedido.Docemissao == "SF" || base.DefinicaoPedido.Pedido.Docemissao == "MF")
        {
            pCMOV.Baseicms = item.Baseicms;
        }
        else
        {
            pCMOV.Baseicms = ((item.Percicm.GetValueOrDefault(0m) == 0m) ? 0m : item.Pvenda);
        }
        pCMOV.Perciss = item.Perciss;
        pCMOV.Vliss = item.Vliss;
        if (item.Perpis.HasValue)
        {
            numseqorig = item.Perpis;
            if ((numseqorig.GetValueOrDefault() > default(decimal)) & numseqorig.HasValue)
            {
                pCMOV.Perpis = item.Perpis;
            }
        }

        pCMOV.Perpis = default(decimal);
        AtualizarInformacoesDeProdutoEEstoqueEIncluir(pCMOVCOMPLE, pCMOV, item.Codprod, item.Numseq, item.Numlote, item.Vlitemtributos, item.Vlitemtributosestadual, item.Qtunitemb, item.Codauxiliar);
        if (!string.IsNullOrEmpty(pCMOV.Codfilialretira) && !pCMOV.Codfilialretira.Equals(pCMOV.Codfilial) && _vendaJaExistente && !ObterParametroBoolean("UTILIZACENTRALFATURAMENTO"))
        {
            GerarMovimentacaoFilialRetira(pCMOV);
        }
        _movimentacoes.Add(pCMOV);
        logFat.Adicionar("FIM    - GerarMovimentacao");
    }

    private void GerarCabelhoDaNota()
    {
        logFat.Adicionar("INICIO - GerarCabelhoDaNota");
        RegistrarLog("Cabeçalho de nota fiscal");
        _nota = new PCNFSAID();
        _nota.Rotinalanc = "nwErp.exe";
        _nota.Especie = "NF";
        _nota.Coddoc = "512";
        if (base.DefinicaoPedido.Pedido.Docemissao != null)
        {
            switch (base.DefinicaoPedido.Pedido.Docemissao)
            {
                case "CE":
                    _nota.Serie = _pedido.Numcaixafiscal.ToString();
                    _nota.Qrcodenfce = base.DefinicaoPedido.Pedido.Qrcodenfce;
                    break;
                case "CF":
                    _nota.Serie = "CF";
                    break;
                case "SF":
                    _nota.Serie = "SF";
                    break;
                case "MF":
                    _nota.Serie = "MF";
                    break;
                default:
                    _nota.Serie = "CF";
                    break;
            }
        }
        _nota.Docemissao = _pedido.Docemissao;
        _nota.Numnota = _pedido.Numcupom.GetValueOrDefault(0m);
        if (_filial.Gerarnsu != null && _filial.Gerarnsu.ToUpper().Contains("S"))
        {
            _nota.Nsu = base.Persistencia.ObterNumeroSequencialDeTabela(_filial, (PCFILIAL fil) => fil.Proxnsu);
        }
        _nota.Dtnsu = _dataProcessamento.Date;
        _nota.Codfilial = _filial.Codigo;
        _nota.Dtsaida = _pedido.Data;
        _nota.Codcont = _pcconsum.Codcontcli.GetValueOrDefault().ToString();
        _nota.Idtipopresenca = base.DefinicaoPedido.Pedido.Idtipopresenca;
        _nota.Codemitentepedido = _pedido.Codemitente;
        if (ZeraNumCar())
        {
            _nota.Numcar = default(decimal);
            logFat.Adicionar("Zerou Numcar {_pedido.Codemitente}");
        }
        else if (_vendaJaExistente)
        {
            if (((_pcconsum.Usanumcarvendabalcao == null) ? "N" : _pcconsum.Usanumcarvendabalcao).ToUpper().Equals("S"))
            {
                _nota.Numcar = _numcar;
            }
            if (_pedidoExistente != null && _pedidoExistente.Origemped != null)
            {
                _ = _pedidoExistente.Numcar;
                if (_pedidoExistente.Origemped.Equals("T"))
                {
                    _nota.Numcar = _numcar;
                }
            }
            logFat.Adicionar("Informou o numcar {this._pedidoExistente.Codemitente}");
            _nota.Codemitentepedido = _pedidoExistente.Codemitente;
        }
        if (_cliente.Codcli == 1m || _cliente.Codcli == 2m || _cliente.Codcli == 3m || _pedido.Docemissao != "NF")
        {
            _nota.Codfiscal = 512m;
        }
        else
        {
            _nota.Codfiscal = ((_filial.Uf == _cliente.Estent) ? 512 : 612);
        }
        _nota.Codcli = _pedido.Codcli;
        _nota.Codusur = _pedido.Codusur;
        _nota.Vltabela = _pedido.Vltabela;
        _nota.Tipovenda = _pedido.Tipovenda;
        _nota.Codplpag = _pedido.Codplpag;
        _nota.Vlcustoreal = _pedido.Vlcustoreal;
        _nota.Vlcustofin = _pedido.Vlcustofin;
        _nota.Numcar = _pedido.Numcar;
        _nota.Totpeso = _pedido.Totpeso;
        _nota.Totvolume = _pedido.Totvolume;
        _nota.Numvolume = _pedido.Numvolume;
        _nota.Codpraca = _pedido.Codpraca;
        _nota.Numitens = _pedido.Numitens;
        _nota.Codemitente = _pedido.Codemitente;
        _nota.Codcob = _pedido.Codcob;
        _nota.Numped = _pedido.Numped;
        decimal? cidade = _cliente.Codcidade;
        if ((base.DefinicaoPedido.Pedido.Codcli == 1m || base.DefinicaoPedido.Pedido.Codcli == 2m || base.DefinicaoPedido.Pedido.Codcli == 3m) && base.DefinicaoPedido.ConsumidorFinal != null && base.DefinicaoPedido.ConsumidorFinal.Count > 0)
        {
            PCVENDACONSUMECF pCVENDACONSUMECF = base.DefinicaoPedido.ConsumidorFinal.SingleOrDefault();
            _nota.Consumidorfinal = pCVENDACONSUMECF.Consumidorfinal;
            _nota.Contribuinte = pCVENDACONSUMECF.Contribuinte;
            cidade = pCVENDACONSUMECF.Codcidade;
        }
        logFat.Adicionar("INICIO - Pesquisa PCCIDADE");
        PCCIDADE pCCIDADE = base.Persistencia.CarregarLista(new PCCIDADE(), (PCCIDADE c) => new { c.Codibge }, (PCCIDADE x) => (decimal?)x.Codcidade == cidade).FirstOrDefault();
        if (pCCIDADE != null && pCCIDADE != null)
        {
            _nota.Codibge = pCCIDADE.Codibge;
        }
        logFat.Adicionar("FIM    - Pesquisa PCCIDADE");
        if (_pedido.Dtentrega < _nota.Dtsaida)
        {
            _nota.Dtentrega = _nota.Dtsaida;
        }
        else
        {
            _nota.Dtentrega = _pedido.Dtentrega;
        }
        _nota.Stribut = default(decimal);
        _nota.Icmsretido = _movimentacoes.Select((PCMOV mov) => mov.Qtcont * mov.St).Sum();
        _nota.Bcst = _movimentacoes.Select((PCMOV mov) => mov.Qtcont * mov.Baseicst).Sum();
        _nota.Comissao = _movimentacoes.Select((PCMOV mov) => mov.Qt * mov.Percom * mov.Punit / (decimal?)100).Sum();
        _nota.Numtransvenda = _pedido.Numtransvenda.GetValueOrDefault(0m);
        _nota.Vldesconto = _pedido.Vldesconto;
        _nota.Vlfrete = _pedido.Vlfrete;
        _nota.Vltotal = _pedido.Vltotal;
        _nota.Vltotger = _pedido.Vlatend;
        _nota.Vloutrasdesp = _pedido.Vloutrasdesp;
        _nota.Condvenda = _pedido.Condvenda;
        _nota.Codsupervisor = _pedido.Codsupervisor;
        _nota.Vlbaseipi = _movimentacoes.Select((PCMOV mov) => mov.Qtcont * mov.Vlbaseipi).Sum();
        _nota.Vlipi = _movimentacoes.Select((PCMOV mov) => mov.Qtcont * mov.Vlipi).Sum();
        _nota.Codepto = _pedido.Codepto;
        _nota.Obs = _pedido.Obs;
        _nota.Codfilialnf = _pedido.Codfilialnf;
        _nota.Vlcustocont = _pedido.Vlcustocont;
        _nota.Vlcustorep = _pedido.Vlcustorep;
        _nota.Numseqmontagem = _pedido.Numseqmontagem;
        _nota.Codcontrato = _pedido.Codcontrato;
        _nota.Fretedespacho = _pedido.Fretedespacho;
        _nota.Freteredespacho = _pedido.Freteredespacho;
        _nota.Codfornecfrete = _pedido.Codfornecfrete;
        _nota.Vlfretenf = _pedido.Vlfretenf;
        _nota.Prazoadicional = default(decimal);
        _nota.Prazomedio = _pedido.Prazomedio;
        _nota.Vliss = _movimentacoes.Select((PCMOV mov) => mov.Qtcont * mov.Vliss).Sum();
        _nota.Serieecf = _pedido.Serieecf;
        _nota.Numcupom = _pedido.Numcupom;
        _nota.Numserieequip = _pedido.Numserieequip;
        _nota.Icmsretidognre = default(decimal);
        _nota.Numorca = _pedido.Numorca;
        if (_vendaJaExistente)
        {
            _nota.Codclinf = _pedidoExistente.Codclinf;
        }
        else
        {
            _nota.Codclinf = _pedido.Codclinf;
        }
        _nota.Bcstgnre = default(decimal);
        _nota.Numcaixafiscal = _pedido.Numcaixafiscal;
        _nota.Numecf = _pedido.Numecf;
        _nota.Numvias = 1;
        _nota.Caixa = _pedido.Numcaixa.GetValueOrDefault(0m);
        _nota.Numseq = _pedido.Numseqentrega;
        _nota.Vlsubtotal = _pedido.Vlsubtotal;
        _nota.Entrega = base.DefinicaoPedido.Pedido.Entrega;
        _nota.Taxaentrega = base.DefinicaoPedido.Pedido.Taxaentrega;
        _nota.Vltributos = base.DefinicaoPedido.Pedido.Vltributos;
        _nota.Numregiao = base.DefinicaoPedido.Pedido.Numregiao;
        _nota.Dtmovimentocx = base.DefinicaoPedido.Pedido.Dtmovimentocx;
        _nota.Numfechamentomovcx = base.DefinicaoPedido.Pedido.Numfechamentomovcx;
        _nota.Md5listaarq = base.DefinicaoPedido.Pedido.Md5listaarq;
        _nota.Vendanfseried = base.DefinicaoPedido.Pedido.Vendanfseried;
        _nota.Datahoraemissaosat = base.DefinicaoPedido.Pedido.Datahoraemissaosat;
        _nota.Chavesat = base.DefinicaoPedido.Pedido.Chavesat;
        _nota.Qrcodesat = base.DefinicaoPedido.Pedido.Qrcodesat;
        _nota.Situacaosat = base.DefinicaoPedido.Pedido.Situacaosat;
        _nota.Numsessaosat = base.DefinicaoPedido.Pedido.Numsessaosat;
        _nota.Codsefazsat = base.DefinicaoPedido.Pedido.Codsefazsat;
        _nota.Codstatussat = base.DefinicaoPedido.Pedido.Codstatussat;
        _nota.Numseriesat = base.DefinicaoPedido.Pedido.Numseriesat;
        _nota.Dthoraautorizacaosefaz = base.DefinicaoPedido.Pedido.Dthoraautorizacaosefaz;
        _nota.Protocolonfe = base.DefinicaoPedido.Pedido.Protocolonfce;
        _nota.Justificativacontigencia = base.DefinicaoPedido.Pedido.Justificativacontigencia;
        _nota.Dtahoraentradacontigencia = base.DefinicaoPedido.Pedido.Dtahoraentradacontigencia;
        _nota.Tipoemissao = base.DefinicaoPedido.Pedido.Tipoemissao;
        _nota.Chavenfe = base.DefinicaoPedido.Pedido.Chavenfce;
        _nota.Situacaonfe = base.DefinicaoPedido.Pedido.Situacaonfce;
        _nota.Obsnfe = base.DefinicaoPedido.Pedido.Obsnfce;
        _nota.Notadupliquesvc = base.DefinicaoPedido.Pedido.Notadupliquesvc;
        _nota.Emaildest = base.DefinicaoPedido.Pedido.Emaildest;
        _nota.Indicadordesconto = base.DefinicaoPedido.Pedido.Indicadordesconto;
        _nota.Indicadoracrescimo = base.DefinicaoPedido.Pedido.Indicadoracrescimo;
        _nota.Descintermediador = base.DefinicaoPedido.Pedido.Descintermediador;
        _nota.Cnpjintermediador = base.DefinicaoPedido.Pedido.Cnpjintermediador;
        if (_vendaJaExistente)
        {
            _nota.Codusur2 = _pedidoExistente.Codusur2;
            logFat.Adicionar("CODUSUR2: " + _pedidoExistente.Codusur2);
            _nota.Codusur3 = _pedidoExistente.Codusur3;
            logFat.Adicionar("CODUSUR3: " + _pedidoExistente.Codusur3);
            _nota.Codusur4 = _pedidoExistente.Codusur4;
            logFat.Adicionar("CODUSUR4: " + _pedidoExistente.Codusur4);
            _nota.Comissao2 = _movimentacoes.Select((PCMOV mov) => mov.Qt * (decimal?)mov.Percom2.GetValueOrDefault(0m) * mov.Punit / (decimal?)100).Sum();
            _nota.Comissao3 = _movimentacoes.Select((PCMOV mov) => mov.Qt * (decimal?)mov.Percom3.GetValueOrDefault(0m) * mov.Punit / (decimal?)100).Sum();
            _nota.Comissao4 = _movimentacoes.Select((PCMOV mov) => mov.Qt * (decimal?)mov.Percom4.GetValueOrDefault(0m) * mov.Punit / (decimal?)100).Sum();
            if (ZeraNumCar())
            {
                _nota.Numcar = default(decimal);
            }
            else
            {
                if (((_pcconsum.Usanumcarvendabalcao == null) ? "N" : _pcconsum.Usanumcarvendabalcao).ToUpper().Equals("S"))
                {
                    _nota.Numcar = _pedidoExistente.Numcar;
                }
                if (_pedidoExistente != null && _pedidoExistente.Origemped != null)
                {
                    _ = _pedidoExistente.Numcar;
                    if (_pedidoExistente.Origemped.Equals("T"))
                    {
                        _nota.Numcar = _pedidoExistente.Numcar;
                    }
                }
            }
        }
        else
        {
            _nota.Codusur2 = base.DefinicaoPedido.Pedido.Codprofissional;
        }
        logFat.Adicionar("INICIO - INSERIR PCNFSAID");
        base.Persistencia.Persistir(TipoPersistencia.INCLUIR, _nota);
        logFat.Adicionar("FIM    - INSERIR PCNFSAID");
        if (_vendaOrcamento)
        {
            if (base.DefinicaoPedido.Pedido.Fichasimportadas != null && base.DefinicaoPedido.Pedido.Fichasimportadas != "")
            {
                logFat.Adicionar("INICIO - Fichas Importadas");
                string[] array = base.DefinicaoPedido.Pedido.Fichasimportadas.Split(',');
                foreach (string ficha in array)
                {
                    PCORCAVENDAC pCORCAVENDAC = base.Persistencia.CarregarLista(new PCORCAVENDAC(), (PCORCAVENDAC p) => p.Numorca == (decimal)int.Parse(ficha) && p.Dtimportacao == null).FirstOrDefault();
                    if (pCORCAVENDAC != null && pCORCAVENDAC != null)
                    {
                        if (string.IsNullOrEmpty(pCORCAVENDAC.Cooconf))
                        {
                            pCORCAVENDAC.Cooconf = _pedido.Numcupom.ToString();
                        }
                        pCORCAVENDAC.Numcupom = _pedido.Numcupom;
                        pCORCAVENDAC.Orcamentoutilizado = "S";
                        pCORCAVENDAC.Dtimportacao = _dataProcessamento.Date;
                        base.Persistencia.Persistir(TipoPersistencia.ALTERAR, pCORCAVENDAC);
                    }
                }
                logFat.Adicionar("FIM    - Fichas Importadas");
            }
            else
            {
                logFat.Adicionar("INICIO - ORÇAMENTO");
                PCORCAVENDAC pCORCAVENDAC2 = base.Persistencia.CarregarLista(new PCORCAVENDAC(), (PCORCAVENDAC oc) => new { oc.Cooconf, oc.Numcupom, oc.Orcamentoutilizado, oc.Dtimportacao }, (PCORCAVENDAC p) => (decimal?)p.Numorca == _pedido.Numorca && p.Orcamentoutilizado != "S" && p.Dtimportacao == null).FirstOrDefault();
                if (pCORCAVENDAC2 != null && pCORCAVENDAC2 != null)
                {
                    if (string.IsNullOrEmpty(pCORCAVENDAC2.Cooconf))
                    {
                        pCORCAVENDAC2.Cooconf = _pedido.Numcupom.ToString();
                    }
                    pCORCAVENDAC2.Numcupom = _pedido.Numcupom;
                    pCORCAVENDAC2.Orcamentoutilizado = "S";
                    pCORCAVENDAC2.Dtimportacao = _dataProcessamento.Date;
                    logFat.Adicionar("INICIO - UPDATE PCORCAVENDAC");
                    base.Persistencia.Persistir(TipoPersistencia.ALTERAR, pCORCAVENDAC2);
                    logFat.Adicionar("FIM    - UPDATE PCORCAVENDAC");
                }
                logFat.Adicionar("FIM    - ORÇAMENTO");
            }
        }
        logFat.Adicionar("FIM    - GerarCabelhoDaNota");
    }

    private void GerarInformacoesDeTributacao()
    {
        logFat.Adicionar("INICIO - GerarInformacoesDeTributacao");
        RegistrarLog("Gerando informacoes de tributacao (PCNFBASE)");
        foreach (List<PCMOV> item in from mov in _movimentacoes
                                     group mov by mov.Percicm.GetValueOrDefault(0m) into movs
                                     select movs.ToList())
        {
            PCNFBASE pCNFBASE = new PCNFBASE();
            pCNFBASE.Aliquota = item.First().Percicm.GetValueOrDefault(0m);
            pCNFBASE.Numtransvenda = item.First().Numtransvenda;
            pCNFBASE.Codcont = _pcconsum.Codcontcli.GetValueOrDefault(0m);
            pCNFBASE.Vlbase = decimal.Round(item.Select((PCMOV mov) => mov.Baseicms.GetValueOrDefault(0m) * mov.Qtcont.GetValueOrDefault(0m)).Sum(), 2);
            pCNFBASE.Vlicms = decimal.Round(item.Select((PCMOV mov) => mov.Baseicms.GetValueOrDefault(0m) * mov.Qtcont.GetValueOrDefault(0m) * (mov.Percicm.GetValueOrDefault(0m) / 100m)).Sum(), 2);
            base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCNFBASE);
        }
        if (_pedido.Vloutrasdesp.GetValueOrDefault(0m) > 0m)
        {
            logFat.Adicionar("INICIO - ConsultaAliquotaOutrasDespesasVisao");
            ConsultaAliquotaOutrasDespesasVisao aliquotas = base.Persistencia.CarregarListaVisao(new ConsultaAliquotaOutrasDespesasVisao(), (ConsultaAliquotaOutrasDespesasVisao aliq) => aliq.Numtransvenda == _pedido.Numtransvenda.GetValueOrDefault(0m) && (aliq.Codfilialnf == null || aliq.Codfilialnf == _pedido.Codfilial)).FirstOrDefault();
            logFat.Adicionar("FIM    - ConsultaAliquotaOutrasDespesasVisao");
            if (aliquotas != null && aliquotas.Aliquota > 0m)
            {
                PCNFBASE pCNFBASE2 = base.Persistencia.CarregarLista(new PCNFBASE(), (PCNFBASE nfbase) => nfbase.Numtransvenda == _pedido.Numtransvenda && nfbase.Aliquota == aliquotas.Aliquota).FirstOrDefault();
                if (pCNFBASE2 != null)
                {
                    pCNFBASE2.Vlbase = decimal.Round(pCNFBASE2.Vlbase + _pedido.Vloutrasdesp.GetValueOrDefault(0m), 2);
                    pCNFBASE2.Vlicms = decimal.Round(pCNFBASE2.Vlbase + pCNFBASE2.Vlbase * (aliquotas.Aliquota / 100m), 2);
                    base.Persistencia.Persistir(TipoPersistencia.ALTERAR, pCNFBASE2);
                }
                else
                {
                    pCNFBASE2 = new PCNFBASE();
                    pCNFBASE2.Numtransvenda = _pedido.Numtransvenda.GetValueOrDefault(0m);
                    pCNFBASE2.Aliquota = aliquotas.Aliquota;
                    pCNFBASE2.Codcont = _pcconsum.Codcontcli.GetValueOrDefault(0m);
                    pCNFBASE2.Vlbase = decimal.Round(_pedido.Vloutrasdesp.GetValueOrDefault(0m), 2);
                    pCNFBASE2.Vlicms = decimal.Round(pCNFBASE2.Vlbase * (aliquotas.Aliquota / 100m), 2);
                    base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCNFBASE2);
                }
            }
        }
        logFat.Adicionar("FIM    - GerarInformacoesDeTributacao");
    }

    private void GerarMovimentacaoFilialRetira(PCMOV movimentacao)
    {
        logFat.Adicionar("INICIO - GerarMovimentacaoFilialRetira");
        PCMOV pCMOV = new PCMOV();
        PCMOV pCMOV2 = new PCMOV();
        PCFILIAL pCFILIAL = base.Persistencia.CarregarLista(new PCFILIAL(), (PCFILIAL f) => f.Codigo == movimentacao.Codfilialretira).FirstOrDefault();
        PCFILIAL pCFILIAL2 = base.Persistencia.CarregarLista(new PCFILIAL(), (PCFILIAL f) => f.Codigo == movimentacao.Codfilial).FirstOrDefault();
        pCMOV2.BuscarSimilaridade(movimentacao);
        pCMOV2.Numtransvenda = ObterNumeradores.ProxNumtransvenda(base.Persistencia);
        pCMOV2.Codoper = "ST";
        pCMOV2.Status = "B";
        pCMOV2.Qtcont = null;
        pCMOV2.Punitcont = null;
        pCMOV2.Codfilialnf = movimentacao.Codfilialretira;
        pCMOV2.Codfilial = movimentacao.Codfilialretira;
        pCMOV2.Numtransitem = base.Persistencia.ObterNumeroSequencial("DFSEQ_PCMOVCOMPLE");
        pCMOV2.Codfiscal = null;
        pCMOV2.Codcli = pCFILIAL2.Codcli.GetValueOrDefault(0m);
        pCMOV2.Codfornec = pCFILIAL.Codfornec;
        if (ZeraNumCar())
        {
            pCMOV2.Numcar = default(decimal);
        }
        else if (_vendaJaExistente)
        {
            if (((_pcconsum.Usanumcarvendabalcao == null) ? "N" : _pcconsum.Usanumcarvendabalcao).ToUpper().Equals("S"))
            {
                pCMOV2.Numcar = _numcar;
            }
            if (_pedidoExistente != null && _pedidoExistente.Origemped != null)
            {
                _ = _pedidoExistente.Numcar;
                if (_pedidoExistente.Origemped.Equals("T"))
                {
                    pCMOV2.Numcar = _numcar;
                }
            }
        }
        if (!pCMOV2.Numcar.HasValue)
        {
            pCMOV2.Numcar = default(decimal);
        }
        base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCMOV2);
        PKG_ESTOQUE.VENDAS_SAIDA vENDAS_SAIDA = new PKG_ESTOQUE.VENDAS_SAIDA();
        if (!base.Persistencia.ProcedureValidaExiste(vENDAS_SAIDA))
        {
            throw new Exception("PACKAGE DE MOVIMENTAÇÃO DE ESTOQUE INVÁLIDA PKG_ESTOQUE.VENDAS_SAIDA");
        }
        vENDAS_SAIDA.pnNUMTRANSACAO = pCMOV2.Numtransvenda.GetValueOrDefault(0m);
        vENDAS_SAIDA.psECANCELAMENTO = "N";
        base.Persistencia.ExecutarProcedure(vENDAS_SAIDA);
        if (vENDAS_SAIDA.Retorno.ToString().Trim() == "0")
        {
            throw new Exception("Erro desconhecido ao realizar a baixa de estoque, nenhum produto foi movimentado pela PKG_ESTOQUE.VENDAS_SAIDA\n, MOTIVO : " + vENDAS_SAIDA.Retorno.ToString());
        }
        pCMOV.BuscarSimilaridade(movimentacao);
        pCMOV.Numtransent = ObterNumeradores.ProxNumtransent(base.Persistencia);
        pCMOV.Numtransvenda = null;
        pCMOV.Codoper = "ET";
        pCMOV.Status = "B";
        pCMOV.Qtcont = null;
        pCMOV.Punitcont = null;
        pCMOV.Codfilialretira = base.DefinicaoPedido.Pedido.Codfilial;
        pCMOV.Codfilialnf = movimentacao.Codfilial;
        pCMOV.Numtransitem = base.Persistencia.ObterNumeroSequencial("DFSEQ_PCMOVCOMPLE");
        pCMOV.Codfiscal = null;
        pCMOV.Codcli = pCFILIAL2.Codcli.GetValueOrDefault(0m);
        pCMOV.Codfornec = pCFILIAL.Codfornec;
        if (ZeraNumCar())
        {
            pCMOV.Numcar = default(decimal);
        }
        else if (_vendaJaExistente)
        {
            if (((_pcconsum.Usanumcarvendabalcao == null) ? "N" : _pcconsum.Usanumcarvendabalcao).ToUpper().Equals("S"))
            {
                pCMOV.Numcar = _numcar;
            }
            if (_pedidoExistente != null && _pedidoExistente.Origemped != null)
            {
                _ = _pedidoExistente.Numcar;
                if (_pedidoExistente.Origemped.Equals("T"))
                {
                    pCMOV.Numcar = _numcar;
                }
            }
        }
        if (!pCMOV.Numcar.HasValue)
        {
            pCMOV.Numcar = default(decimal);
        }
        base.Persistencia.Persistir(TipoPersistencia.INCLUIR, pCMOV);
        PKG_ESTOQUE.VENDAS_ENTRADA vENDAS_ENTRADA = new PKG_ESTOQUE.VENDAS_ENTRADA();
        if (!base.Persistencia.ProcedureValidaExiste(vENDAS_ENTRADA))
        {
            throw new Exception("PACKAGE DE MOVIMENTAÇÃO DE ESTOQUE INVÁLIDA PKG_ESTOQUE.VENDAS_ENTRADA");
        }
        vENDAS_ENTRADA.pnNUMTRANSACAO = pCMOV.Numtransent.GetValueOrDefault(0m);
        vENDAS_ENTRADA.psECANCELAMENTO = "N";
        logFat.Adicionar("INICIO - ExecutarProcedure VENDAS_ENTRADA");
        base.Persistencia.ExecutarProcedure(vENDAS_ENTRADA);
        logFat.Adicionar("FIM    - ExecutarProcedure, RETORNO: " + vENDAS_ENTRADA.psMSG_RETORNO.ToString());
        if (vENDAS_ENTRADA.Retorno.ToString().Trim() == "0")
        {
            throw new Exception("Erro desconhecido ao realizar a baixa de estoque, nenhum produto foi movimentado pela PKG_ESTOQUE.VENDAS_ENTRADA");
        }
        logFat.Adicionar("FIM    - GerarMovimentacaoFilialRetira");
    }

    private bool ObterParametroPorFilial(string nomeparametro)
    {
        logFat.Adicionar("INICIO - ObterParametroPorFilial , PARAMETRO: " + nomeparametro.ToString());
        bool result = false;
        if (base.Persistencia.ContarRegistros<PCPARAMFILIAL>((PCPARAMFILIAL pcp) => pcp.Nome.ToUpper().Equals(nomeparametro) && pcp.Valor.ToUpper().Equals("S") && pcp.Codfilial == DefinicaoPedido.Pedido.Codfilial) > 0)
        {
            result = true;
        }
        logFat.Adicionar("FIM    - ObterParametroPorFilial, resultado: " + result);
        return result;
    }

    private void AtualizarInformacoesDeProdutoEEstoqueEIncluir(PCMOVCOMPLE complemento, PCMOV movimentacao, decimal codprod, decimal numseq, string Numlote, decimal? vlitemtributos, decimal? vlitemtributosest, decimal? qtunitemb, decimal? codauxiliar)
    {
        try
        {
            logFat.Adicionar("INICIO - AtualizarInformacoesDeProdutoEEstoqueEIncluir");
            logFat.Adicionar("INICIO - CarregarLista PCPRODUT");
            PCPRODUT pCPRODUT = base.Persistencia.CarregarLista(new PCPRODUT(), (PCPRODUT prod) => new { prod.Codepto, prod.Codsec, prod.Codfornec, prod.Codprodprinc, prod.Estoqueporlote, prod.Extipi }, (PCPRODUT prod) => prod.Codprod == codprod).First();
            logFat.Adicionar("FIM    - CarregarLista PCPRODUT");
            logFat.Adicionar("INICIO - CarregarLista PCEMBALAGEM");
            PCEMBALAGEM pCEMBALAGEM = base.Persistencia.CarregarLista(new PCEMBALAGEM(), (PCEMBALAGEM e) => e.Codfilial == movimentacao.Codfilial && e.Codauxiliar == ((decimal?)codauxiliar).GetValueOrDefault(0m)).FirstOrDefault();
            logFat.Adicionar("FIM    - CarregarLista PCEMBALAGEM");
            if (pCEMBALAGEM != null && pCEMBALAGEM != null)
            {
                movimentacao.Descricao = ((!string.IsNullOrEmpty(pCEMBALAGEM.Descricaoecf)) ? pCEMBALAGEM.Descricaoecf : pCPRODUT.Descricao);
            }
            movimentacao.Codepto = pCPRODUT.Codepto;
            movimentacao.Codsec = pCPRODUT.Codsec;
            movimentacao.Codfornec = pCPRODUT.Codfornec;
            movimentacao.Codprodprinc = pCPRODUT.Codprodprinc;
            movimentacao.Numlote = (((pCPRODUT.Estoqueporlote ?? "N") == "S") ? Numlote : null);
            movimentacao.Qtunitemb = qtunitemb;
            decimal numPed = base.DefinicaoPedido.Pedido.Numped.GetValueOrDefault();
            pCPRODUT.Codauxiliar.GetValueOrDefault(0m);
            if (_vendaJaExistente)
            {
                logFat.Adicionar("INICIO - CarregarLista PCPEDI");
                PCPEDI pCPEDI = base.Persistencia.CarregarLista(new PCPEDI(), (PCPEDI pcpedi) => pcpedi.Numped == numPed && pcpedi.Codprod == codprod && pcpedi.Numseq == numseq).FirstOrDefault();
                logFat.Adicionar("FIM    - CarregarLista PCPEDI");
                if (pCPEDI != null)
                {
                    movimentacao.Percom2 = pCPEDI.Percom2;
                    movimentacao.Percom3 = pCPEDI.Percom3;
                    movimentacao.Percom4 = pCPEDI.Percom4;
                }
            }
            logFat.Adicionar("INICIO - CarregarLista PCEST");
            PCEST pCEST = base.Persistencia.CarregarLista(new PCEST(), (PCEST est) => new { est.Numtransentultent, est.Aliqicms1, est.Perfcpstret }, (PCEST est) => est.Codprod == codprod && est.Codfilial == DefinicaoPedido.Pedido.Codfilial).First();
            logFat.Adicionar("FIM    - CarregarLista PCEST");
            if (complemento.Aliqicms1ret.GetValueOrDefault(0m) == 0m)
            {
                complemento.Aliqicms1ret = pCEST.Aliqicms1;
            }
            if (complemento.Perfcpstret.GetValueOrDefault(0m) == 0m)
            {
                complemento.Perfcpstret = pCEST.Perfcpstret;
            }
            movimentacao.Numtransentultent = pCEST.Numtransentultent;
            logFat.Adicionar("INICIO - OBTER NUMTRANSVENDA");
            movimentacao.Numtransitem = base.Persistencia.ObterNumeroSequencial("DFSEQ_PCMOVCOMPLE");
            logFat.Adicionar("FIM    - OBTER NUMTRANSVENDA");
            logFat.Adicionar("INICIO - INCLUIR PCMOV");
            logFat.Adicionar($"CONEXAO COM BANCO DE DADOS ESTÁ ATIVO ? {base.Persistencia.TestarConexao().ToString()}");
            base.Persistencia.Persistir(TipoPersistencia.INCLUIR, movimentacao);
            logFat.Adicionar(string.Format("OS DADOS DA PC MOV FOI PERSISTIDO ? {0} , Numtransvenda {1}", movimentacao != null, movimentacao.Numtransvenda, ToString()));
            logFat.Adicionar("FIM    - INCLUIR PCMOV");
            decimal? numtransultentst = pCEST.Numtransultentst;
            if ((numtransultentst.GetValueOrDefault() > default(decimal)) & numtransultentst.HasValue)
            {
                complemento.Numtransultentstant = pCEST.Numtransultentst;
            }
            GerarComplementoDoItem(complemento, movimentacao, pCPRODUT, vlitemtributos, vlitemtributosest);
            logFat.Adicionar("FIM    - AtualizarInformacoesDeProdutoEEstoqueEIncluir");
        }
        catch (Exception ex)
        {
            logFat.GravarExcecao(ex);
            throw ex;
        }
    }

    private void GerarComplementoDoItem(PCMOVCOMPLE complemento, PCMOV movimentacao, PCPRODUT produto, decimal? vlitemtributos, decimal? vlitemtributosest)
    {
        logFat.Adicionar("INICIO - GerarComplementoDoItem");
        complemento.Numtransitem = movimentacao.Numtransitem.GetValueOrDefault(-1m);
        complemento.Extipi = produto.Extipi;
        complemento.Dtregistro = base.Persistencia.UltimaDataHora;
        complemento.Vlicms = movimentacao.Baseicms * (movimentacao.Percicm / (decimal?)100);
        complemento.Vlitemtributos = vlitemtributos;
        complemento.Vlitemtributosest = vlitemtributosest;
        complemento.Codsittribipi = ObterTributacaoIPI(movimentacao.Codcli, movimentacao.Codprod, movimentacao.Codfilial, movimentacao.Dtmov);
        if (complemento.Numseqorig.HasValue)
        {
            decimal? numseqorig = complemento.Numseqorig;
            if ((numseqorig.GetValueOrDefault() <= default(decimal)) & numseqorig.HasValue)
            {
                complemento.Numseqorig = null;
            }
        }
        logFat.Adicionar("INICIO - INSERIR PCMOVCOMPLE");
        base.Persistencia.Persistir(TipoPersistencia.INCLUIR, complemento);
        logFat.Adicionar($"DADOS DA PCMOVCOMPLE PERSISTIDOS, {complemento != null} , Numtransitem: {complemento.Numtransitem} ");
        logFat.Adicionar("FIM    - INSERIR PCMOVCOMPLE");
        logFat.Adicionar("FIM    - GerarComplementoDoItem");
    }

    private decimal ObterTributacaoIPI(decimal codcli, decimal codprod, string codfilial, DateTime data)
    {
        logFat.Adicionar("INICIO - ObterTributacaoIPI");
        FISCAL.GET_DADOS_TRIBUTACAO_IPI gET_DADOS_TRIBUTACAO_IPI = new FISCAL.GET_DADOS_TRIBUTACAO_IPI();
        gET_DADOS_TRIBUTACAO_IPI.P_CODCLI = codcli;
        gET_DADOS_TRIBUTACAO_IPI.P_CODPROD = codprod;
        gET_DADOS_TRIBUTACAO_IPI.P_CODFILIAL = codfilial;
        gET_DADOS_TRIBUTACAO_IPI.P_DATAOPERACAO = data;
        try
        {
            if (base.Persistencia.ProcedureValidaExiste(gET_DADOS_TRIBUTACAO_IPI))
            {
                base.Persistencia.ExecutarProcedure(gET_DADOS_TRIBUTACAO_IPI);
            }
        }
        catch (Exception)
        {
        }
        logFat.Adicionar("FIM    - ObterTributacaoIPI");
        return gET_DADOS_TRIBUTACAO_IPI.P_CST_SAIDA;
    }

    public bool ProdutoEhAcabado(decimal codprod)
    {
        int num = base.Persistencia.ContarRegistros<PCPRODUT>((PCPRODUT prod) => prod.Codprod == codprod && (prod.Tipomerc == "PA" || prod.Tipomerc == "SA"));
        if (base.Persistencia.ContarRegistros<PCFORMPROD>((PCFORMPROD f) => f.Codprodacab == codprod) > 0)
        {
            return num > 0;
        }
        return false;
    }

    private async void GerarCancelamentoWTA()
    {
        decimal? numpedcanc = base.DefinicaoPedido.Pedido.Numpedcanc;
        if (!((numpedcanc.GetValueOrDefault() > default(decimal)) & numpedcanc.HasValue))
        {
            return;
        }
        logFat.Adicionar("INICIO - Cancelamento WTA");
        PCPEDC pCPEDC = base.Persistencia.CarregarLista(new PCPEDC(), (PCPEDC x) => new { x.Numped }, (PCPEDC x) => (decimal?)x.Numped == DefinicaoPedido.Pedido.Numpedcanc).FirstOrDefault();
        if (pCPEDC != null && pCPEDC != null)
        {
            int num = 0;
            while (!await CancelamentoWTAAsync(pCPEDC) && num < 5)
            {
                num++;
                Thread.Sleep(500);
            }
            pCPEDC.Numped = 0m;
        }
        logFat.Adicionar("FIM - Cancelamento WTA");
    }

    private void EfetuarBaixaDeEstoque()
    {
        decimal[] codigoProdutos = ObterCodigoDosProdutos();
        List<PCEST> list = base.Persistencia.CarregarLista(new PCEST(), (PCEST est) => new { est.Codprod, est.Codfilial }, (PCEST est) => est.Codfilial == _filial.Codigo && codigoProdutos.Contains(est.Codprod));
        logFat.Adicionar($"THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} INICIO - BLOQUEAR REGISTROS ");
        base.Persistencia.BloquearRegistros(list, carregarEntidade: true);
        logFat.Adicionar($"THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} FIM   - BLOQUEAR REGISTROS ");
        BaixarEstoqueNormal(list);
        logFat.Adicionar($"THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} FIM   - CARREGAR PRODUTOS A SEREM MOVIMENTADOS - NUMPEDECF: {base.DefinicaoPedido.Pedido.Numpedecf} ");
        logFat.Adicionar($"THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} FINALIZANDO MOVIMENTAÇÃO DE ESTOQUE #### ");
    }

    private async Task<bool> CancelamentoWTAAsync(PCPEDC pedidoOriginal)
    {
        string ipMobile = ObterParametroString("IPMOBILE");
        string portaMobile = ObterParametroString("PORTAMOBILE");

        if (string.IsNullOrEmpty(ipMobile) || string.IsNullOrEmpty(portaMobile))
        {
            return false;
        }

        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Preparar a URL de login
                string loginUrl = $"http://{ipMobile}:{portaMobile}/winthor/autenticacao/v1/login";

                // Obter dados do usuário
                PCEMPR pCEMPR = base.Persistencia.ConsultaPorSQL<PCEMPR>($"select nome_guerra, decrypt(senhabd, usuariobd) senhabd from pcempr where matricula = {1}").FirstOrDefault();

                // Preparar o conteúdo do login
                string loginContent = "{ \"login\": \"" + pCEMPR.Nome_Guerra + "\", \"senha\": \"" + HashMD5.ObterHashDoTexto(pCEMPR.Senhabd.Trim()).ToUpper() + "\"}";
                HttpContent httpContent = new StringContent(loginContent, Encoding.UTF8, "application/json");

                // Logar a tentativa de login
                logFat.Adicionar("LOGIN COM USUARIO " + pCEMPR.Nome_Guerra);
                logFat.Adicionar($"URL={loginUrl}");

                // Enviar requisição de login
                HttpResponseMessage loginResponse = await client.PostAsync(loginUrl, httpContent);
                loginResponse.EnsureSuccessStatusCode();

                // Ler a resposta do login
                string responseString = await loginResponse.Content.ReadAsStringAsync();
                if (!responseString.Contains("accessToken"))
                {
                    logFat.Adicionar("RESPOSTA DO LOGIN " + responseString);
                    return false;
                }

                // Extrair o token de acesso
                string accessToken = ExtractAccessToken(responseString);
                logFat.Adicionar("PEGOU TOKEN");

                if (!string.IsNullOrEmpty(accessToken))
                {
                    // Preparar a URL de cancelamento
                    string cancelUrl = $"http://{ipMobile}:{portaMobile}/api/wholesale/v1/orders/?id={pedidoOriginal.Numped}&reasonCancellation=Cancelamento da Rotina 2075&sendMessageRca=false";
                    logFat.Adicionar(cancelUrl);

                    // Configurar a requisição de cancelamento
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    // Enviar requisição de cancelamento
                    HttpResponseMessage cancelResponse = await client.DeleteAsync(cancelUrl);
                    cancelResponse.EnsureSuccessStatusCode();

                    // Ler a resposta do cancelamento
                    string cancelResponseString = await cancelResponse.Content.ReadAsStringAsync();
                    logFat.Adicionar(cancelResponseString);

                    return true;
                }

                return false;
            }
        }
        catch (HttpRequestException ex)
        {
            // Adiciona a mensagem de erro no log
            logFat.Adicionar($"Erro durante a requisição HTTP: {ex.Message}");

            // Se a exceção contém uma resposta, processa a resposta de erro
            if (ex.Data.Contains("HttpResponseMessage"))
            {
                var response = ex.Data["HttpResponseMessage"] as HttpResponseMessage;
                if (response != null)
                {
                    logFat.Adicionar($"Status Code: {(int)response.StatusCode} {response.StatusCode}");

                    string errorResponse = await response.Content.ReadAsStringAsync();
                    logFat.Adicionar(errorResponse);
                }
            }

            return false;
        }
    }

    private string ExtractAccessToken(string responseString)
    {
        // Implementar a lógica para extrair o token de acesso da resposta JSON
        int startIndex = responseString.IndexOf("\"accessToken\": \"") + 17;
        int endIndex = responseString.IndexOf("\"", startIndex);
        return responseString.Substring(startIndex, endIndex - startIndex);
    }

    private decimal[] ObterCodigoDosProdutos()
    {
        decimal[] array = (from prod in _movimentacoes
                           where prod.Tipomerc != "PA"
                           select prod.Codprod).Distinct().ToArray();
        if (ObterParametroPorFilial("USAPRODUCAOSOBDEMANDA"))
        {
            return (from prod in _movimentacoes
                    where prod.Tipomerc != "PA" && prod.Tipomerc != "SA"
                    select prod.Codprod).Distinct().ToArray();
        }
        return _movimentacoes.Select((PCMOV prod) => prod.Codprod).Distinct().ToArray();
    }

    private void BaixarEstoqueNormal(List<PCEST> listaEstoqueProdutos)
    {
        logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} INICIO - BAIXAR ESTOQUE NORMAL ");
        PKG_ESTOQUE.VENDAS_SAIDA vENDAS_SAIDA = new PKG_ESTOQUE.VENDAS_SAIDA();
        if (!base.Persistencia.ProcedureValidaExiste(vENDAS_SAIDA))
        {
            throw new Exception("PACKAGE DE MOVIMENTAÇÃO DE ESTOQUE INVÁLIDA PKG_ESTOQUE.VENDAS_SAIDA");
        }
        vENDAS_SAIDA.pnNUMTRANSACAO = base.DefinicaoPedido.Pedido.Numtransvenda.GetValueOrDefault(0m);
        vENDAS_SAIDA.psECANCELAMENTO = "N";
        logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} INICIO - EXECUTAR PROCEDURE VENDAS_SAIDA NUMTRANSACAO: {base.DefinicaoPedido.Pedido.Numtransvenda.GetValueOrDefault(0m)} ");
        base.Persistencia.ExecutarProcedure(vENDAS_SAIDA);
        logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} FIM   - EXECUTAR PROCEDURE VENDAS_SAIDA NUMTRANSACAO: {base.DefinicaoPedido.Pedido.Numtransvenda.GetValueOrDefault(0m)} ");
        if (vENDAS_SAIDA.Retorno.ToString().Trim() == "0")
        {
            throw new Exception("Erro desconhecido ao realizar a baixa de estoque, nenhum produto foi movimentado pela PKG_ESTOQUE.VENDAS_SAIDA\n, MOTIVO : " + vENDAS_SAIDA.psMSG_RETORNO.ToString());
        }
        foreach (PCEST estoque in listaEstoqueProdutos)
        {
            IEnumerable<PCMOV> itensMovimentados = _movimentacoes.Where((PCMOV prod) => prod.Codprod == estoque.Codprod);
            logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} INICIO - ATUALIZACAO DE CUSTO E GIRO - PRODUTO: {estoque.Codprod}");
            ExecutarMovimentacaoDoEstoque(estoque, itensMovimentados, false);
            base.Persistencia.Persistir(TipoPersistencia.ALTERAR, estoque);
            logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} FIM    - ATUALIZACAO DE CUSTO E GIRO - PRODUTO: {estoque.Codprod}");
        }
        logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} FIM   - BAIXAR ESTOQUE NORMAL ");
    }

    private void ExecutarMovimentacaoDoEstoque(PCEST estoque, IEnumerable<PCMOV> itensMovimentados, bool baixarEstoqueGerencial)
    {
        logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} ESTOQUE ANTERIOR - PRODUTO: {estoque.Codprod}, QTVENDDIA: {estoque.Qtvenddia}, QTVENDSEMANA: {estoque.Qtvendsemana} QTVENDMES: {estoque.Qtvendmes}");
        itensMovimentados.Select((PCMOV prod) => prod.Qtcont.GetValueOrDefault(0m)).Sum();
        decimal num = itensMovimentados.Select((PCMOV prod) => prod.Qt.GetValueOrDefault(0m)).Sum();
        logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} CODPROD: {estoque.Codprod} , QUANTIDADE VENDIDA: {num}");
        estoque.Qtvenddia = estoque.Qtvenddia.GetValueOrDefault(0m) + num;
        estoque.Qtvendsemana = estoque.Qtvendsemana.GetValueOrDefault(0m) + num;
        estoque.Qtvendmes = estoque.Qtvendmes.GetValueOrDefault(0m) + num;
        decimal num2 = itensMovimentados.Select((PCMOV prod) => prod.Qt.GetValueOrDefault(0m) * prod.Punit.GetValueOrDefault(0m)).Sum();
        estoque.Vlvenddia = estoque.Vlvenddia.GetValueOrDefault(0m) + num2;
        estoque.Vlvendmes = estoque.Vlvendmes.GetValueOrDefault(0m) + num2;
        estoque.Vlvenddiareal = estoque.Vlvenddiareal.GetValueOrDefault(0m) + num2;
        estoque.Vlvendmesreal = estoque.Vlvendmesreal.GetValueOrDefault(0m) + num2;
        estoque.Vlvenddia = decimal.Round(estoque.Vlvenddia.GetValueOrDefault(0m), 2);
        estoque.Vlvendmes = decimal.Round(estoque.Vlvendmes.GetValueOrDefault(0m), 2);
        estoque.Vlvenddiareal = decimal.Round(estoque.Vlvenddiareal.GetValueOrDefault(0m), 2);
        estoque.Vlvendmesreal = decimal.Round(estoque.Vlvendmesreal.GetValueOrDefault(0m), 2);
        decimal d = itensMovimentados.Select((PCMOV prod) => prod.Qt.GetValueOrDefault(0m) * prod.Custoreal.GetValueOrDefault(0m)).Sum();
        d = decimal.Round(d, 2);
        estoque.Vlcustodiareal = estoque.Vlcustodiareal.GetValueOrDefault(0m) + d;
        estoque.Vlcustomesreal = estoque.Vlcustomesreal.GetValueOrDefault(0m) + d;
        estoque.Vlcustodiareal = decimal.Round(estoque.Vlcustodiareal.GetValueOrDefault(0m), 2);
        estoque.Vlcustomesreal = decimal.Round(estoque.Vlcustomesreal.GetValueOrDefault(0m), 2);
        decimal d2 = itensMovimentados.Select((PCMOV prod) => prod.Qt.GetValueOrDefault(0m) * prod.Custofin.GetValueOrDefault(0m)).Sum();
        d2 = decimal.Round(d2, 2);
        estoque.Vlcustodiafin = estoque.Vlcustodiafin.GetValueOrDefault(0m) + d2;
        estoque.Vlcustomesfin = estoque.Vlcustomesfin.GetValueOrDefault(0m) + d2;
        estoque.Vlcustodiafin = decimal.Round(estoque.Vlcustodiafin.GetValueOrDefault(0m), 2);
        estoque.Vlcustomesfin = decimal.Round(estoque.Vlcustomesfin.GetValueOrDefault(0m), 2);
        estoque.Dtultsaida = _dataProcessamento.Date;
        estoque.Dtultfat = _dataProcessamento.Date;
        estoque.Assinatura = HashMD5.ObterHashDoTexto(estoque.Qtestger.ToString());
        logFat.Adicionar($" THREAD ID: {Thread.CurrentThread.ManagedThreadId.ToString()} ESTOQUE ATUALIZADO - PRODUTO: {estoque.Codprod}, QTVENDDIA: {estoque.Qtvenddia}, QTVENDSEMANA: {estoque.Qtvendsemana} QTVENDMES: {estoque.Qtvendmes}");
    }

    private PCMOV NovoItemDeMovimentacao()
    {
        logFat.Adicionar("INICIO - NovoItemDeMovimentacao");
        PCMOV result = new PCMOV
        {
            Numped = base.DefinicaoPedido.Pedido.Numped,
            Numtransvenda = base.DefinicaoPedido.Pedido.Numtransvenda,
            Numnota = base.DefinicaoPedido.Pedido.Numcupom.GetValueOrDefault(0m),
            Dtmov = base.DefinicaoPedido.Pedido.Data,
            Codfilial = base.DefinicaoPedido.Pedido.Codfilial,
            Codfilialnf = base.DefinicaoPedido.Pedido.Codfilial,
            Codcli = base.DefinicaoPedido.Pedido.Codcli,
            Codplpag = base.DefinicaoPedido.Pedido.Codplpag,
            Codusur = base.DefinicaoPedido.Pedido.Codusur,
            Numregiao = base.DefinicaoPedido.Pedido.Numregiao,
            Numcar = base.DefinicaoPedido.Pedido.Numcar,
            Codoper = "S",
            Rotinalanc = "nwErp.exe",
            Numidf = _filial.Numidf,
            Horalanc = _dataProcessamento.ToString("HH"),
            Minutolanc = _dataProcessamento.Minute.ToString()
        };
        logFat.Adicionar("FIM    - NovoItemDeMovimentacao");
        return result;
    }

}

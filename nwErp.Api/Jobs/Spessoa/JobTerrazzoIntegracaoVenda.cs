using Hangfire;
using Hangfire.Console;
using Hangfire.Server;
using Microsoft.Data.SqlClient;
using nwErp.Api.Persistencia;
using nwErp.Api.Entidades.DTOs;
using Dapper;
using ExportadorNFCe.XMLNFe;
using System.Xml;
using nwErp.Api.Configuration;
using System.Globalization;

namespace nwErp.Api.Jobs
{

    public class JobTerrazzoIntegracaoVenda : IHostedService
    {
        private readonly string connectionTerrazzo;
        private readonly string connectionWinthor;
        private readonly IConfiguration _configuration;
        private readonly IPersistencia _persistencia;
        private PCFECHAMENTOMOVCX _pcmovcx;
        private PCPEDCECF _pedidoExistente;
        private List<PCPEDIECF> _pcpediecf = new List<PCPEDIECF>();
        private List<PCPEDCCANCECF> _pcpedccancecf = new List<PCPEDCCANCECF>();
        private List<PCPEDICANCECF> _pcpedicancecf = new List<PCPEDICANCECF>();
        private List<PCPRESTECF> _pcprestecf = new List<PCPRESTECF>();
        private List<PCORIGEMPRECOECF> _origempreco = new List<PCORIGEMPRECOECF>();
        private List<PCDOCELETRONICOECF> _documento = new List<PCDOCELETRONICOECF>();

        public JobTerrazzoIntegracaoVenda(IConfiguration configuration, IPersistencia persistencia)
        {
            _configuration = configuration;
            _persistencia = persistencia;
            connectionTerrazzo = _configuration.GetConnectionString("SqlServerConnection");
            connectionWinthor = _configuration.GetConnectionString("OracleDbConnection");
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Configure();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            // Lógica de parada pode ser adicionada aqui
            return Task.CompletedTask;
        }

        public static void Configure()
        {
            UtilidadeLogConsole.LogConsole("Iniciando processo de criação de estrutura no HangFire", nameof(Configure), UtilidadeLogConsole.TipoMensagem.Atencao);
            CriarTasksJobs();
            UtilidadeLogConsole.LogConsole("Estrutura do HangFire criada com sucesso!", nameof(Configure), UtilidadeLogConsole.TipoMensagem.Sucesso);
        }

        public static void CriarTasksJobs()
        {
            RecurringJob.AddOrUpdate<JobTerrazzoIntegracaoVenda>("Integrar ControleCx", x => x.GetControleCxAsync(null, CancellationToken.None), Cron.Hourly(2), TimeZoneInfo.Local);
            RecurringJob.AddOrUpdate<JobTerrazzoIntegracaoVenda>("Integrar Notafiscal - Fila", x => x.GetNotasFiscaisAsync(null, CancellationToken.None), Cron.Hourly(2), TimeZoneInfo.Local);
        }

        public async Task GetControleCxAsync(PerformContext context, CancellationToken cancellationToken)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(connectionTerrazzo))
                {
                    await sqlConnection.OpenAsync(cancellationToken);
                    var data = await sqlConnection.QueryAsync<DTI_TERRAZZO_CONTROLECX>(
                        ExecutaComandoScript("Query_ControleCX"));

                    if (data != null && data.Any())
                    {
                        foreach (var it in data)
                        {
                            var lista = _persistencia.CarregarLista(new PCFECHAMENTOMOVCX(),
                                (PCFECHAMENTOMOVCX pcmovcx) => pcmovcx.Numfechamentomovcx == it.ID_CAIXA);

                            _pcmovcx = lista?.FirstOrDefault() ?? new PCFECHAMENTOMOVCX();

                            if (_pcmovcx != null && _pcmovcx.Numfechamentomovcx == it.ID_CAIXA)
                            {
                                // A instância já existe, não é necessário continuar
                                if (_pcmovcx.Dtfechamento == null && it.DATAFIM != null)
                                {

                                    _pcmovcx.Dtfechamento = it.DATAFIM;
                                    _persistencia.Persistir(TipoPersistencia.ALTERAR, _pcmovcx);
                                }

                                continue;
                            }


                            decimal numeroCarregamento = 0;

                            _pcmovcx.Codfilial = "2";
                            _pcmovcx.Codfunccx = it.MATRICULA;
                            _pcmovcx.Numcaixa = 300;
                            _pcmovcx.Numfechamentomovcx = it.ID_CAIXA;
                            _pcmovcx.Nummovimentopdv = numeroCarregamento;
                            _pcmovcx.Dtmovimentocx = it.DATAINICIO;
                            _pcmovcx.Dtabertura = it.DATAINICIO;
                            _pcmovcx.Dtfechamento = it.DATAFIM;
                            _pcmovcx.Exportado = "S";
                            _pcmovcx.Horaabertura = Convert.ToDecimal(it.HORAINICIO.Substring(0, 2));
                            _pcmovcx.Minutoabertura = 0;
                            _pcmovcx.Horafechamento = Convert.ToDecimal(it.HORAFIM.Substring(0, 2));
                            _persistencia.Persistir(TipoPersistencia.INCLUIR, _pcmovcx);
                            _pcmovcx = null; // Resetar a instância após o uso
                        }
                    }
                    else
                    {
                        context.WriteLine("Nenhum dado encontrado na consulta SQL.");
                    }

                }
            }
            catch (SqlException ex)
            {
                context.WriteLine($"Erro SqlException: {ex.Number} - {ex.Message}");
                UtilidadeLogConsole.LogConsole($"Erro SqlException: {ex.Number} - {ex.Message}",
                    nameof(GetControleCxAsync), UtilidadeLogConsole.TipoMensagem.Erro);
                context.WriteLine(ex.ToString());
                throw;
            }
                
            catch (Exception ex)
            {
                UtilidadeLogConsole.LogConsole($"ConnectionString:{connectionTerrazzo}",
                    nameof(GetControleCxAsync), UtilidadeLogConsole.TipoMensagem.Atencao);
                UtilidadeLogConsole.LogConsole($"Falha: {ex.StackTrace} - {ex.Message}",
                    nameof(GetControleCxAsync), UtilidadeLogConsole.TipoMensagem.Erro);
                cancellationToken.ThrowIfCancellationRequested();
            }
        }

        public async Task GetNotasFiscaisAsync(PerformContext context, CancellationToken cancellationToken)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(connectionTerrazzo))
                {
                    await sqlConnection.OpenAsync(cancellationToken);
                    if (sqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        var notafiscal = await sqlConnection.QueryAsync<TerrazzoNotaFiscal>(ExecutaComandoScript("Query_NotasFiscais"));
                        foreach (var nota in notafiscal)
                        {
                            BackgroundJob.Enqueue(() => ProcessarNotaFiscalAsync(nota, cancellationToken));
                            
                        }
                    }
                }
            }
            catch (Exception e0)
            {
                context.WriteLine($"Erro: {e0.StackTrace}");
                UtilidadeLogConsole.LogConsole($"Falha ao gravar: {e0.StackTrace}", nameof(GetNotasFiscaisAsync), UtilidadeLogConsole.TipoMensagem.Erro);
                cancellationToken.ThrowIfCancellationRequested();
            }

        }

        [AutomaticRetry(Attempts = 0)]
        public async Task ProcessarNotaFiscalAsync(TerrazzoNotaFiscal nota, CancellationToken cancellationToken)
        {
            try
            {


                if (nota == null) 
                {
                    UtilidadeLogConsole.LogConsole("A nota fiscal é nula.", nameof(ProcessarNotaFiscalAsync), UtilidadeLogConsole.TipoMensagem.Erro);
                    return;
                }

                // Carregar pedido existente
                _pedidoExistente = _persistencia.CarregarLista(new PCPEDCECF(), pcped => pcped.Numpedecf == nota.Id).FirstOrDefault();

                if (_pedidoExistente != null)
                {
                    UtilidadeLogConsole.LogConsole($"Documento Já Importado: {_pedidoExistente.Chavenfce}", nameof(ProcessarNotaFiscalAsync), UtilidadeLogConsole.TipoMensagem.Atencao);
                    return;
                }

                //var carregamento = _persistencia.CarregarLista(new PCFECHAMENTOMOVCX(),
                //    pcmovcx => pcmovcx.Nummovimentopdv == nota.ID_CONTARECEBER).FirstOrDefault();

                // Preparar o caminho do arquivo XML
                string caminholocal = nota.LocalXml.Replace("C:\\Mogo Gourmet Offline\\App\\XmlNotalFiscal\\", "/mnt/xmlnotafiscal/");  
                
                if (!File.Exists(caminholocal))
                {
                    UtilidadeLogConsole.LogConsole($"Arquivo XML não encontrado: {caminholocal}", nameof(ProcessarNotaFiscalAsync), UtilidadeLogConsole.TipoMensagem.Erro);
                    return;
                }

                // Ler o conteúdo do arquivo XML
                string xmlContent = File.ReadAllText(caminholocal);

                if (string.IsNullOrEmpty(xmlContent))
                {
                    UtilidadeLogConsole.LogConsole($"Erro: {caminholocal}", nameof(ProcessarNotaFiscalAsync), UtilidadeLogConsole.TipoMensagem.Erro);
                    return;
                }

                // Desserializar o XML
                NFeSerialization xmlnfe = new NFeSerialization();
                var nfe = xmlnfe.GetObjectFromFile<NFeProc>(caminholocal);

                if (nfe == null)
                {
                    UtilidadeLogConsole.LogConsole($"Falha: {nota.Id}", nameof(ProcessarNotaFiscalAsync), UtilidadeLogConsole.TipoMensagem.Erro);
                    return;
                }

                if(nota.ModNfe == 55)
                {
                    // Modelo 55 = NFE - Nota fiscal eletronica / DANFE - A4
                    // Modelo 65 = NFCE - Nota fiscal consumidor eletronica / DANFCE - Cupom Fiscal
                    UtilidadeLogConsole.LogConsole($"Xml de uma NF-e Mod 55: {nota.Id}", nameof(ProcessarNotaFiscalAsync), UtilidadeLogConsole.TipoMensagem.Erro);
                    return;
        
                }

                // Configuração da entidade PCPEDCECF
                int nItens = nfe.NotaFiscalEletronica.InformacoesNFe.det.Count;

                PCPEDCECF _pcpedcecf = new PCPEDCECF();

                _pcpedcecf.Numpedecf = nota.Id;
                _pcpedcecf.Codfunccx = nota.Matricula;
                _pcpedcecf.Exportado = "N";
                _pcpedcecf.Codemitente = nota.Matricula;
                _pcpedcecf.Numcaixa = 300;
                _pcpedcecf.Codcob = "DH";
                _pcpedcecf.Numserieequip = "NotaFiscal";
                _pcpedcecf.Data = Convert.ToDateTime(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString());
                _pcpedcecf.Codfilial = "2";
                _pcpedcecf.Codcli = 1;
                _pcpedcecf.Codusur = 30;
                _pcpedcecf.Codpraca = 100;
                _pcpedcecf.Codsupervisor = 30;
                _pcpedcecf.Codplpag = 1;
                _pcpedcecf.Posicao = "L";
                _pcpedcecf.Condvenda = 1;
                _pcpedcecf.Percvenda = 100;
                _pcpedcecf.Numcupom = nota.ModNfe == 65 ? Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF) : 0;
                _pcpedcecf.Serieecf = nota.ModNfe == 65 ? "X" : "NF";
                _pcpedcecf.Dtentrega = Convert.ToDateTime(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString());
                _pcpedcecf.Vlatend = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture);
                _pcpedcecf.Vltotal = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture);
                _pcpedcecf.Vltabela = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture);
                _pcpedcecf.Vldesconto = null;
                _pcpedcecf.Tipovenda = "VV";
                _pcpedcecf.Vloutrasdesp = null;
                _pcpedcecf.Numitens = nfe.NotaFiscalEletronica.InformacoesNFe.det.Count;
                _pcpedcecf.Hora = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToString("HH"));
                _pcpedcecf.Minuto = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToString("mm"));
                _pcpedcecf.Prazo1 = 0;
                _pcpedcecf.Prazo2 = 0;
                _pcpedcecf.Prazo3 = 0;
                _pcpedcecf.Prazo4 = 0;
                _pcpedcecf.Prazo5 = 0;
                _pcpedcecf.Prazo6 = 0;
                _pcpedcecf.Prazo7 = 0;
                _pcpedcecf.Prazo8 = 0;
                _pcpedcecf.Prazo9 = 0;
                _pcpedcecf.Prazo10 = 0;
                _pcpedcecf.Prazo11 = 0;
                _pcpedcecf.Prazo12 = 0;
                _pcpedcecf.Prazomedio = 0;
                _pcpedcecf.Numviasmapasep = 1;
                _pcpedcecf.Operacao = "N";
                _pcpedcecf.Vlcustoreal = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture) * 0.8M;
                _pcpedcecf.Vlcustofin = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture) * 0.8M;
                _pcpedcecf.Totpeso = 0;
                _pcpedcecf.Totvolume = 0;
                _pcpedcecf.Vlcustorep = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture) * 0.8M;
                _pcpedcecf.Vlcustocont = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture) * 0.8M;
                //_pcpedcecf.Numped = _pedidoExistente.NumPed;
                //_pcpedcecf.Numtransvenda = _pedidoExistente.Numtransvenda;
                _pcpedcecf.Dtexportacao = null;
                _pcpedcecf.Numcaixafiscal = 300;
                _pcpedcecf.Gerardadosnfpaulista = null;
                _pcpedcecf.Versaorotina = null;
                _pcpedcecf.Numccf = null;
                _pcpedcecf.Numregiao = 100;
                _pcpedcecf.Vltotalcomtroco = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture);
                _pcpedcecf.Usadebcredrca = "S";
                _pcpedcecf.Faturanotaservfat = "S";
                _pcpedcecf.Chavenfce = nfe.infProt.ProtocoloNFe.chNFe;
                _pcpedcecf.Protocolonfce = nfe.infProt.ProtocoloNFe.nProt;
                _pcpedcecf.Naturezanfce = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.natOp;
                _pcpedcecf.Dthoraautorizacaosefaz = Convert.ToDateTime(nfe.infProt.ProtocoloNFe.dhRecbto);
                _pcpedcecf.Tipoemissao = "1";
                _pcpedcecf.Situacaonfce = Convert.ToDecimal(nfe.infProt.ProtocoloNFe.cStat);
                _pcpedcecf.Usacredrca = "S";
                _pcpedcecf.Perdesc = null;
                _pcpedcecf.Vlsubtotal = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, CultureInfo.InvariantCulture);
                _pcpedcecf.Idtipopresenca = "1";
                _pcpedcecf.Ambientenfce = "P";
                _pcpedcecf.Docemissao = "CE";
                _pcpedcecf.Numfechamentomovcx = 0;
                _pcpedcecf.Dtmovimentocx = Convert.ToDateTime(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString());
                _pcpedcecf.Identificarclientenfce = "S";
                _pcpedcecf.Numvolume = 0;
                _pcpedcecf.Vltributos = 0;
                _pcpedcecf.Vldescsociotorcedor = 0;
                _pcpedcecf.Tipomovccrca = "VF";
                //_pcpedcecf.Entrega = _pedidoExistente.Entrega;
                //_pcpedcecf.Taxaentrega = _pedidoExistente.Taxaentrega;
                _pcpedcecf.Horacupom = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToString("HH:mm:ss");
                _pcpedcecf.Numsessaosat = Convert.ToDecimal(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.cNF);
                _pcpedcecf.Custofinest = null;
                //_pcpedcecf.Vlfrete = _pedidoExistente.Vlfrete;
                //_pcpedcecf.Fretedespacho = _pedidoExistente.Fretedespacho;
                _pcpedcecf.Versaominfaturamento = "29.0.41.16";
                //_pcpedcecf.Qrcodenfce = _pedidoExistente.Qrcodenfce;
                

                await GravaItens(nItens, caminholocal, _pcpedcecf);
                _pcpedcecf.Codcob = await GravaFinanceiro(nota.Id, _pcpedcecf);
                _persistencia.Persistir(TipoPersistencia.INCLUIR, _pcpedcecf);
                
                PCDOCELETRONICOECF docecf = new PCDOCELETRONICOECF();
                docecf.Exportado = "N";
                docecf.Numpedecf = _pcpedcecf.Numpedecf;
                docecf.Codfunccx = _pcpedcecf.Codfunccx;
                docecf.Numcaixa = _pcpedcecf.Numcaixa;
                docecf.Numserieequip = _pcpedcecf.Numserieequip;
                docecf.Data = _pcpedcecf.Data;
                docecf.Codfilial = _pcpedcecf.Codfilial;
                docecf.Xmlnfce = xmlContent.ToString();
                _persistencia.Persistir(TipoPersistencia.INCLUIR, docecf);
                await InserirIdNfe(nota.Id);
            }
            catch (Exception ex)
            {
                UtilidadeLogConsole.LogConsole($"ErroNF - {nota.Id}: {ex.StackTrace}", nameof(ProcessarNotaFiscalAsync),UtilidadeLogConsole.TipoMensagem.Erro);
                throw;

            }



        }


        private async Task GravaItens(int nItens, string localnfe, PCPEDCECF _pcpedcecf)
        {
            string cst = "";
            decimal? pICMS = 0;
            
            try //ITEM DE PEDIDO
            {
                CultureInfo cultura = CultureInfo.InvariantCulture;
                NFeSerialization xmlnfe = new NFeSerialization();
                XmlDocument xmlDoc = new XmlDocument();

                var nfe = xmlnfe.GetObjectFromFile<NFeProc>(localnfe);
                #region Lista Itens - XML Mogo - MOGO_PCPEDIECF 
                for (int i = 0; i < nItens; i++)
                {

                    var detalhe = nfe.NotaFiscalEletronica.InformacoesNFe.det[i];
                    var item = new PCPEDIECF();

                    #region Desserializar Impostos ICMS do XML NFCe / XML NFe
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS00))
                    {
                        cst = ((ICMS00)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = ((ICMS00)detalhe.imposto.ICMS.TipoICMS).pICMS;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS10))
                    {
                        cst = ((ICMS10)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = ((ICMS10)detalhe.imposto.ICMS.TipoICMS).pICMS;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS40))
                    {
                        cst = ((ICMS40)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = 0;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS51))
                    {
                        cst = ((ICMS51)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = ((ICMS51)detalhe.imposto.ICMS.TipoICMS).pICMS;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS60))
                    {
                        cst = ((ICMS60)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = 0;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS70))
                    {
                        cst = ((ICMS70)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = ((ICMS70)detalhe.imposto.ICMS.TipoICMS).pICMS;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS90))
                    {
                        cst = ((ICMS00)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = ((ICMS00)detalhe.imposto.ICMS.TipoICMS).pICMS;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMSPart))
                    {
                        cst = ((ICMS90)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = ((ICMS90)detalhe.imposto.ICMS.TipoICMS).pICMS;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMSST))
                    {
                        cst = ((ICMSST)detalhe.imposto.ICMS.TipoICMS).CST;
                        pICMS = 0;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMSSN101))
                    {
                        cst = ((ICMSSN101)detalhe.imposto.ICMS.TipoICMS).CSOSN;
                        pICMS = ((ICMSSN101)detalhe.imposto.ICMS.TipoICMS).pCredSN;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMSSN102))
                    {
                        cst = ((ICMSSN102)detalhe.imposto.ICMS.TipoICMS).CSOSN;
                        pICMS = ((ICMSSN102)detalhe.imposto.ICMS.TipoICMS).pCredSN;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMSSN201))
                    {
                        cst = ((ICMSSN201)detalhe.imposto.ICMS.TipoICMS).CSOSN;
                        pICMS = 0;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMSSN202))
                    {
                        cst = ((ICMSSN202)detalhe.imposto.ICMS.TipoICMS).CSOSN;
                        pICMS = 0;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMSSN500))
                    {
                        cst = ((ICMSSN500)detalhe.imposto.ICMS.TipoICMS).CSOSN;
                        pICMS = ((ICMSSN500)detalhe.imposto.ICMS.TipoICMS).pICMSEfet;
                    }
                    if (detalhe.imposto.ICMS.TipoICMS.GetType() == typeof(ICMSSN900))
                    {
                        cst = ((ICMSSN900)detalhe.imposto.ICMS.TipoICMS).CSOSN;
                        pICMS = ((ICMSSN900)detalhe.imposto.ICMS.TipoICMS).pCredSN;
                    }
                    #endregion
                    #endregion

                    
                    int WinthorCodprod = await CodigoProdutoAsync(detalhe.Produto.cProd);
                    item.Exportado = "N";
                    item.Numpedecf = _pcpedcecf.Numpedecf;
                    item.Codfunccx = _pcpedcecf.Codfunccx;
                    item.Numcaixa = _pcpedcecf.Numcaixa;
                    item.Numserieequip = _pcpedcecf.Numserieequip;
                    item.Codprod = WinthorCodprod > 0 ? WinthorCodprod : 225;
                    item.Numseq = detalhe.nItem;
                    item.Data = _pcpedcecf.Data;
                    item.Codcli = _pcpedcecf.Codcli;
                    item.Codusur = _pcpedcecf.Codusur;
                    item.Qt = Convert.ToDecimal(detalhe.Produto.qCom, cultura);
                    item.Pvenda = Convert.ToDecimal(detalhe.Produto.vUnCom, cultura);
                    item.Ptabela = Convert.ToDecimal(detalhe.Produto.vUnCom, cultura); //Convert.ToDecimal(_icms.Pvenda1);
                    item.St = 0;
                    item.Perdesc = 0;
                    item.Qtfalta = 0;
                    item.Codst = detalhe.Produto.CFOP == "5102" ? 11 : 25;
                    item.Poriginal = Convert.ToDecimal(detalhe.Produto.vUnCom, cultura);
                    item.Percbaseredstfonte = 0;
                    item.Vlipi = 0;
                    item.Percipi = 0;
                    item.Percbaseredst = 0;
                    item.Perfretecmv = 0;
                    item.Codauxiliar = 300000000 + item.Codprod;
                    item.Percom = 0;
                    item.Vlcustofin = Convert.ToDecimal(detalhe.Produto.vUnCom, cultura) * 0.55M;
                    item.Vlcustoreal = Convert.ToDecimal(detalhe.Produto.vUnCom, cultura) * 0.55M;
                    item.Vlcustocont = Convert.ToDecimal(detalhe.Produto.vUnCom, cultura) * 0.55M;
                    item.Vlcustorep = Convert.ToDecimal(detalhe.Produto.vUnCom, cultura) * 0.55M;
                    item.Numped = null;
                    item.Numcar = 0;
                    item.Dtexportacao = DateTime.UtcNow;
                    item.Codecf = detalhe.Produto.CFOP == "5102" ? "1900" : "FF";
                    item.Numcaixafiscal = 300;
                    item.Vldescrodape = 0;
                    item.Vlacrescrodape = 0;
                    item.Truncaritem = null;
                    item.Codfilial = "2";
                    item.Custofinest = item.Vlcustocont;
                    item.Rotinalanc = 2075;
                    item.Baseicst = 0;
                    item.Qtunitemb = 1;
                    item.Vldifaliquotas = 0;
                    item.Percdifaliquotas = 0;
                    item.Basedifaliquotas = 0;
                    item.Vldescreducaocofins = 0;
                    item.Vldescreducaopis = 0;
                    item.Vlcofins = item.Poriginal * 0.076M;
                    item.Percofins = 7.6M;
                    item.Vlpis = item.Poriginal * 0.0165M; ;
                    item.Perpis = 1.65M;
                    item.Codfiscal = Convert.ToDecimal(detalhe.Produto.CFOP);
                    item.Sittribut = cst;
                    item.Baseicms = detalhe.Produto.CFOP == "5102" ? item.Poriginal : 0;
                    item.Bciss = 0;
                    item.Vliss = 0;
                    item.Perciss = 0;
                    item.Vlbaseipi = 0;
                    item.Percdesccofins = 0;
                    item.Percdescpis = 0;
                    item.Iva = 0;
                    item.Aliqicms1 = 0;
                    item.Aliqicms2 = 0;
                    item.Pauta = 0;
                    item.Pbaserca = item.Poriginal;
                    item.Txvenda = null;
                    item.Codicmtab = detalhe.Produto.CFOP == "5102" ? 29.25M : 9.25M;
                    item.Peracrescimocusto = null;
                    item.Percicm = detalhe.Produto.CFOP == "5102" ? 19M : 0M;
                    item.Vldescorgaopub = null;
                    item.Numseqorig = null;
                    item.Percipiecf = null;
                    item.Vlipiecf = null;
                    item.Baseipiecf = null;
                    item.Codcampanha = null;
                    item.Codfilialretira = null;
                    item.Tipomerc = "L";
                    item.Vlsubtotitem = Convert.ToDecimal(detalhe.Produto.vProd, cultura);
                    item.Origmerctrib = "0";
                    item.Vlitemtributos = 0;
                    item.Perctributos = 0;
                    item.Vlitemtributosestadual = null;
                    item.Vldescsociotorcedor = 0;
                    item.Percicmssimplesnac = 0;
                    item.Vlricmssimplesnac = 0;
                    item.Usapiscofinslit = "N";
                    item.Qtlitragem = 0;
                    item.Codsittribpiscofins = 1;
                    item.Vlbasepiscofins = item.Poriginal;
                    item.Numcoo = Convert.ToDecimal(_pcpedcecf.Numcupom);
                    item.Numccf = 0;
                    item.Percbasered = null;
                    item.Codcontrolevasilhame = null;
                    item.Codvasilhameecf = 0;
                    item.Qtsaidavasilhame = 0;
                    item.Qtvendidavasilhame = 0;
                    item.Vlacrescvasilhame = 0;
                    item.Pvendavasilhame = 0;
                    item.Perdifereimentoicms = 0;
                    item.Piscofinsdeduzido = "N";
                    item.Codtribpiscofins = 1;
                    item.Aliqreducaopis = 0;
                    item.Aliqreducaocofins = 0;
                    item.Enviaraliqreducaopiscofins = "N";
                    item.Aliqfcp = 0;
                    item.Aliqinternadest = 0;
                    item.Percprovpart = 0;
                    item.Vlbasepartdest = 0;
                    item.Vlfcppart = 0;
                    item.Vlicmsdifaliqpart = 0;
                    item.Vlicmspart = 0;
                    item.Vlicmspartdest = 0;
                    item.Vlicmspartrem = 0;
                    item.Percbaseredpart = 0;
                    item.Aliqinterorigpart = 0;
                    item.Perdesccusto = 0;
                    item.Anp = 0;
                    item.Pglp = 0;
                    item.Pgnn = 0;
                    item.Pgni = 0;
                    item.Utilizoumotorcalculo = null;
                    item.Descricaopaf = detalhe.Produto.xProd;
                    item.Peracrescimofuncep = detalhe.Produto.CFOP == "5102" ? 1 : 0; ;
                    item.Vlbasefcpicms = detalhe.Produto.CFOP == "5102" ? item.Poriginal : 0; ;
                    item.Vlacrescimofuncep = detalhe.Produto.CFOP == "5102" ? item.Poriginal * 0.01M : 0; ;
                    item.Aliqicmsfecp = 0;
                    item.Vlbasefcpst = detalhe.Produto.CFOP == "5102" ? 0 : item.Poriginal;
                    item.Vlfecp = 0;
                    item.Vlbcfcpstret = 0;
                    item.Perfcpstret = detalhe.Produto.CFOP == "5102" ? 0 : 1;
                    item.Vlfcpstret = 0;
                    item.Vlfrete = 0;
                    item.Perfcpsn = 0;
                    item.Vlcredfcpicmssn = null;
                    item.Valorultent = item.Vlcustocont;
                    item.Custoultent = item.Vlcustocont;
                    item.Percredbaseefet = 0;
                    item.Vlbaseefet = 0;
                    item.Percicmsefet = 0;
                    item.Vlicmsefet = 0;
                    item.Basebcr = 0;
                    item.Stbcr = 0;
                    item.Vldescontomotoroferta = 0;
                    item.Baseicmsbcr = 0;
                    item.Vlicmsbcr = 0;
                    item.Vldescsuframa = 0;
                    item.Vldescitem = 0;
                    item.Codfornec = 128;
                    _persistencia.Persistir(TipoPersistencia.INCLUIR, item);
                }
                


            }
            catch (Exception e2)
            {

                _persistencia.CancelarTransacao();
                Console.WriteLine($"Erro: {e2.StackTrace} - {e2.Message}");
                BackgroundJob.Enqueue(() => RegistrarErro(e2));
                throw e2;

            } //ITENS DE PEDIDO

        }

        private async Task<int> CodigoProdutoAsync(string cProd)
        {
            try //CODIGO PRODUTO
            {
                using (SqlConnection connection = new SqlConnection(connectionTerrazzo))
                {
                    string query = @"
                        SELECT TOP 1 ISNULL(T.CODPROD, 225) AS CODIGO 
                        FROM ZPRODUTOSWINTHOR T 
                        WHERE T.CPROD = @CProd";

                    await connection.OpenAsync();

                    int codprod = await connection.QuerySingleOrDefaultAsync<int>(query, new { CProd = cProd });

                    return codprod;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.StackTrace} - {ex.Message}");
                BackgroundJob.Enqueue(() => RegistrarErro(ex));
                throw;
            }


        }

        public void RegistrarErro(Exception ex)
        {
            Console.WriteLine($"Erro: {ex.StackTrace} - {ex.Message}");
        }

        private async Task<string> GravaFinanceiro(int IdNota, PCPEDCECF _pcpedcecf)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionTerrazzo))
                {
                    int numprest = 0;

                    await connection.OpenAsync();
                    var parcelas = await connection.QueryAsync<TerrazzoPagamento>(
                        ExecutaComandoScript("Query_Pagamentos"), new {codNotaFiscal = IdNota});
                    if (!parcelas.Any())
                    {
                        numprest++;
                        var prestacoes = CriarPrestacao(_pcpedcecf, null, numprest);
                        _persistencia.Persistir(TipoPersistencia.INCLUIR, prestacoes);
                    }

                    if (parcelas.Any())
                    {
                        foreach (var prest in parcelas)
                        {
                            numprest++;
                            var prestacoes = CriarPrestacao(_pcpedcecf, prest, numprest);
                            _persistencia.Persistir(TipoPersistencia.INCLUIR, prestacoes);
                            
                        }
                        
                    }
                }



            }
            catch (Exception e3)
            {
                _persistencia.CancelarTransacao();
                Console.WriteLine($"Erro: {e3.StackTrace} - {e3.Message}");
                BackgroundJob.Enqueue(() => RegistrarErro(e3));
                throw;
            }

            return _pcpedcecf.Codcob;
        }

        private PCPRESTECF CriarPrestacao(PCPEDCECF _pcpedcecf, TerrazzoPagamento parcela, int numprest)
        {
            try
            {

                var prestacoes = new PCPRESTECF
                {
                    Exportado = "N",
                    Numpedecf = _pcpedcecf.Numpedecf,
                    Prestecf = numprest.ToString(),
                    Prest = numprest.ToString(),
                    Presttef = 1,
                    Codfunccheckout = _pcpedcecf.Codfunccx,
                    Numcheckout = 300,
                    Numserieequip = "NotaFiscal",
                    Duplic = Convert.ToDecimal(_pcpedcecf.Numcupom),
                    Codcli = _pcpedcecf.Codcli,
                    Valor = parcela != null ? Convert.ToDecimal(parcela.Valor) : Convert.ToDecimal(_pcpedcecf.Vlatend),
                    Dtvenc = parcela != null ? Convert.ToDateTime(parcela.Dtvenc) : Convert.ToDateTime(_pcpedcecf.Data),
                    Codcob = parcela != null ? parcela.CODCOB : _pcpedcecf.Codcob,
                    Dtemissao = Convert.ToDateTime(_pcpedcecf.Data),
                    Codfilial = _pcpedcecf.Codfilial,
                    Status = "A",
                    Codusur = _pcpedcecf.Codusur,
                    Dtvencorig = Convert.ToDateTime(_pcpedcecf.Data),
                    Dtbaixa = Convert.ToDateTime(_pcpedcecf.Data),
                    Operacao = "N",
                    Boleto = "N",
                    Codsupervisor = 30,
                    Valororig = Convert.ToDecimal(_pcpedcecf.Vlatend),
                    Codfilialnf = "2",
                    Numcar = 0,
                    Numcaixafiscal = 300,
                    Codcobsefaz = parcela?.COBSEFAZ.ToString(),
                    Nsutef = parcela?.Nsu.ToString(),
                    Codadmcartao = parcela?.CODADMCARTAO,
                    Tipooperacaotef = parcela?.TIPOOPERACAOTEF,
                    Codbandeiratef = parcela?.CODBANDEIRATEF,
                    Numfechamentomovcx = parcela != null ? Convert.ToDecimal(parcela.ControleCaixa) : 0,
                };

                if (parcela != null)
                {
                    _pcpedcecf.Numfechamentomovcx = Convert.ToDecimal(parcela.ControleCaixa);
                    _pcpedcecf.Dtmovimentocx = parcela.Emissao;
                }

                return prestacoes;

            }
            catch (Exception e4)
            {
                Console.WriteLine($"Erro: {e4.StackTrace} - {e4.Message}");
                BackgroundJob.Enqueue(() => RegistrarErro(e4));
                throw;
            }


        }

        public async Task InserirIdNfe(int idNfe)
        {
            using (var connection = new SqlConnection(connectionTerrazzo))
            {
                string query = "INSERT INTO CONTROLE_INTEGRACAO(IDNFE) VALUES (@IDNFE)";
            
                var parameters = new { IDNFE = idNfe };
            
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public string ExecutaComandoScript(string nomeScript)
        {
            string baseDirectory = AppContext.BaseDirectory;
            if (!File.Exists(Path.Combine(baseDirectory, "Script", nomeScript + ".sql")))
                return null;
            string @string = File.ReadAllText(Path.Combine(baseDirectory, "Script", nomeScript + ".sql"));
            if (string.IsNullOrEmpty(@string))
                return null;
            return @string.ToString();
        }

    }
}
using System.Text;
using nwErp.Api.Definicoes;
using nwErp.Api.Entidades;
using nwErp.Api.Persistencia;

namespace nwErp.Api.Importadores;

public class ImportadorComplemento
{
    private DefinicaoComplemento _complemento;

	private IPersistencia _persistencia;

	private StringBuilder _inconsistencias;

	private StringBuilder _logImportacao;

	private static readonly object _object = new object();

	private const string COBRANCA_DINHEIRO = "D";

	public ImportadorComplemento(DefinicaoComplemento complemento, IPersistencia persistencia, StringBuilder inconsistencias)
	{
		_complemento = complemento;
		_persistencia = persistencia;
		_inconsistencias = inconsistencias;
	}

    public void Importar()
    {
        if (_complemento == null || !_complemento.PossuiRegistros)
		{
			return;
		}

        try
        {
            _logImportacao =  new StringBuilder();
            ImportarCancelamentos(_complemento.PCPEDCCANCECF, _complemento.PCPEDICANCECF, _complemento.PCAUTORIECF, _complemento.PCDOCELETRONICOECF, _complemento.PCVENDACONSUMECF);
            ImportarDocEletronicoECF(_complemento.PCDOCELETRONICOECF);
			ImportarInutilizacaoNFCE(_complemento.PCINUTILIZACAONFCE);
            ImportarFechamentoPorMovimento(_complemento.PCFECHAMENTOMOVCX);

        }
        catch
        {


        }        

    }

    private void ImportarCancelamentos(List<PCPEDCCANCECF> cabecalhos, List<PCPEDICANCECF> itens, List<PCAUTORIECF> autorizacoes, List<PCDOCELETRONICOECF> doceletronico, List<PCVENDACONSUMECF> consumidores)
	{
		try
		{
			_persistencia.IniciarTransacao();
			foreach (PCPEDCCANCECF cabecalho in cabecalhos)
			{
				if (_persistencia.ContarRegistros<PCPEDCCANCECF>((PCPEDCCANCECF cab) => cab.Numcaixa == cabecalho.Numcaixa && cab.Numpedecf == cabecalho.Numpedecf) == 0)
				{
					_persistencia.Persistir(TipoPersistencia.INCLUIR, cabecalho);
				}
				else
				{
					PCPEDCCANCECF pCPEDCCANCECF = _persistencia.CarregarLista(new PCPEDCCANCECF(), (PCPEDCCANCECF cab) => cab.Numcaixa == cabecalho.Numcaixa && cab.Numpedecf == cabecalho.Numpedecf).FirstOrDefault();
					if (pCPEDCCANCECF != null)
					{
						pCPEDCCANCECF.BuscarSimilaridade(cabecalho);
						_persistencia.Persistir(TipoPersistencia.ALTERAR, pCPEDCCANCECF);
					}
				}
				List<PCPRESTECF> list = _persistencia.CarregarLista(new PCPRESTECF(), (PCPRESTECF c) => c.Numpedecf == cabecalho.Numpedecf && c.Numcheckout == cabecalho.Numcaixa && c.Dtemissao == cabecalho.Data).ToList();
				if (list.Count <= 0)
				{
					continue;
				}
				foreach (PCPRESTECF item in list)
				{
					if (item != null && item != null && item.Md5paf != null)
					{
						item.Md5paf = null;
						_persistencia.Persistir(TipoPersistencia.ALTERAR, item);
					}
				}
			}
			foreach (PCPEDICANCECF itemCancelamento in itens)
			{
				if (_persistencia.ContarRegistros<PCPEDICANCECF>((PCPEDICANCECF item) => item.Numcaixa == itemCancelamento.Numcaixa && item.Numpedecf == itemCancelamento.Numpedecf && item.Codprod == itemCancelamento.Codprod && item.Numseq == itemCancelamento.Numseq) == 0)
				{
					_persistencia.Persistir(TipoPersistencia.INCLUIR, itemCancelamento);
					continue;
				}
				PCPEDICANCECF pCPEDICANCECF = _persistencia.CarregarLista(new PCPEDICANCECF(), (PCPEDICANCECF item) => item.Numcaixa == itemCancelamento.Numcaixa && item.Codprod == itemCancelamento.Codprod && item.Numseq == itemCancelamento.Numseq && item.Numpedecf == itemCancelamento.Numpedecf).FirstOrDefault();
				if (pCPEDICANCECF != null)
				{
					pCPEDICANCECF.BuscarSimilaridade(itemCancelamento);
					_persistencia.Persistir(TipoPersistencia.ALTERAR, pCPEDICANCECF);
				}
			}
			foreach (PCAUTORIECF autorizacao in autorizacoes)
			{
				if (_persistencia.ContarRegistros<PCAUTORIECF>((PCAUTORIECF autori) => autori.Nrautorizacaoecf == autorizacao.Nrautorizacaoecf && autori.Numpedecf == autorizacao.Numpedecf && autori.Codfunccx == autorizacao.Codfunccx && autori.Numcaixa == autorizacao.Numcaixa && autori.Serieequip == autorizacao.Serieequip && autori.Dataautorizacao == autorizacao.Dataautorizacao) == 0)
				{
					_persistencia.Persistir(TipoPersistencia.INCLUIR, autorizacao);
				}
			}
			foreach (PCVENDACONSUMECF consumidor in consumidores)
			{
				if (_persistencia.ContarRegistros<PCVENDACONSUMECF>((PCVENDACONSUMECF cons) => cons.Numpedecf == consumidor.Numpedecf && cons.Numcaixa == consumidor.Numcaixa) == 0)
				{
					_persistencia.Persistir(TipoPersistencia.INCLUIR, consumidor);
				}
			}
			CancelamentoAutomatico();
			_persistencia.FinalizarTransacao();
		}
		catch (Exception ex)
		{
			new LogFaturamento("COMPLEMENTO_BASE", TipoLogFaturamento.Complemento).GravarExcecao(ex);
			_persistencia.CancelarTransacao();
			_logImportacao.AppendLine("Erro ao importar cancelamentos: ");
			_logImportacao.AppendLine("");
			_logImportacao.AppendLine(ex.Message);
			_logImportacao.AppendLine(ex.StackTrace);
		}
	}

    private void ImportarInutilizacaoNFCE(List<PCINUTILIZACAONFCE> inutilizacaonfce)
	{
		foreach (PCINUTILIZACAONFCE item in inutilizacaonfce)
		{
			PCINUTILIZACAONFCE inut = item;
			_persistencia.IniciarTransacao();
			try
			{
				List<PCINUTILIZACAONFCE> list = _persistencia.CarregarLista(new PCINUTILIZACAONFCE(), (PCINUTILIZACAONFCE pa) => pa.Numnotafinal == inut.Numnotafinal && pa.Numnotainicial == inut.Numnotainicial && pa.Serie == inut.Serie && pa.Codfilial == inut.Codfilial && pa.Ano == inut.Ano);
				if (list != null && list.Count > 0)
				{
					foreach (PCINUTILIZACAONFCE item2 in list)
					{
						_persistencia.Persistir(TipoPersistencia.DELETAR, item2);
					}
				}
				NFCE_INUTILIZARNUMERACAO nFCE_INUTILIZARNUMERACAO = new NFCE_INUTILIZARNUMERACAO();
				if (!_persistencia.ProcedureValidaExiste(nFCE_INUTILIZARNUMERACAO))
				{
					throw new Exception("Procedure de Inutilização NFCE_INUTILIZARNUMERACAO Inválida ou Inexistente, não foi possível realizar a inutilização das numerações.");
				}
				nFCE_INUTILIZARNUMERACAO.P_AMBIENTE = ((inut.Ambiente == "P") ? "1" : inut.Ambiente);
				nFCE_INUTILIZARNUMERACAO.P_ANO = inut.Ano;
				nFCE_INUTILIZARNUMERACAO.P_CODFILIAL = inut.Codfilial;
				nFCE_INUTILIZARNUMERACAO.P_CODUSUARIO = inut.Codusuario.GetValueOrDefault(0m);
				nFCE_INUTILIZARNUMERACAO.P_DTHORAPROCESSAMENTO = inut.Dthoraprocessamento.GetValueOrDefault(DateTime.Now);
				nFCE_INUTILIZARNUMERACAO.P_JUSTIFICATIVA = inut.Justificativa;
				nFCE_INUTILIZARNUMERACAO.P_NUMFINAL = inut.Numnotafinal;
				nFCE_INUTILIZARNUMERACAO.P_NUMINICIAL = inut.Numnotainicial;
				nFCE_INUTILIZARNUMERACAO.P_PROTOCOLO = inut.Protocoloinutilizacao;
				nFCE_INUTILIZARNUMERACAO.P_SERIE = inut.Serie;
				nFCE_INUTILIZARNUMERACAO.P_TIPOMOV = "S";
				nFCE_INUTILIZARNUMERACAO.P_CAIXA = inut.Numcaixa.GetValueOrDefault(0m);
				_persistencia.ExecutarProcedure(nFCE_INUTILIZARNUMERACAO);
				_persistencia.FinalizarTransacao();
			}
			catch (Exception ex)
			{
				_persistencia.CancelarTransacao();
				_logImportacao.AppendLine($"Erro ao importar Inutilização NFCE - Serie {inut.Serie}: {ex.Message}");
				_logImportacao.AppendLine("*** REALIZE O DOWNLOAD E ATUALIZAÇÃO DA ROTINA 1460 E TENTE SINCRONIZAR NOVAMENTE ***");
			}
		}
	}

    private void ImportarFechamentoPorMovimento(List<PCFECHAMENTOMOVCX> fechamentomov)
	{
		foreach (PCFECHAMENTOMOVCX item in fechamentomov)
		{
			PCFECHAMENTOMOVCX prodfechamento = item;
			_persistencia.IniciarTransacao();
			try
			{
				PCFECHAMENTOMOVCX pCFECHAMENTOMOVCX = _persistencia.CarregarLista(new PCFECHAMENTOMOVCX(), (PCFECHAMENTOMOVCX pa) => pa.Codfunccx == prodfechamento.Codfunccx && pa.Numcaixa == prodfechamento.Numcaixa && pa.Numfechamentomovcx == prodfechamento.Numfechamentomovcx).FirstOrDefault();
				if (pCFECHAMENTOMOVCX != null && pCFECHAMENTOMOVCX != null)
				{
					_persistencia.Persistir(TipoPersistencia.DELETAR, pCFECHAMENTOMOVCX);
				}
				_persistencia.Persistir(TipoPersistencia.INCLUIR, prodfechamento);
				_persistencia.FinalizarTransacao();
			}
			catch (Exception ex)
			{
				_persistencia.CancelarTransacao();
				_logImportacao.AppendLine($"Erro ao importar fechamento por movimento para o caixa {prodfechamento.Numcaixa}: {ex.Message}");
			}
		}
	}

    private void ImportarComplementoNFCE(List<PCCOMPLEMENTONFCE> complementonfce)
	{
		foreach (PCCOMPLEMENTONFCE item in complementonfce)
		{
			PCCOMPLEMENTONFCE complemento = item;
			_persistencia.IniciarTransacao();
			try
			{
				if (complemento.Operacao == "CO")
				{
					decimal? codstatus = complemento.Codstatus;
					decimal num = 100;
					if (!((codstatus.GetValueOrDefault() == num) & codstatus.HasValue))
					{
						codstatus = complemento.Codstatus;
						num = 150;
						if (!((codstatus.GetValueOrDefault() == num) & codstatus.HasValue))
						{
							goto IL_081b;
						}
					}
					if (!string.IsNullOrEmpty(complemento.Chavenfce))
					{
						PCNFSAID pCNFSAID = _persistencia.CarregarLista(new PCNFSAID(), (PCNFSAID nfs) => new { nfs.Numtransvenda }, (PCNFSAID nf) => (decimal?)nf.Numnota == complemento.Numnota && nf.Codfilial == complemento.Codfilial && nf.Numcaixafiscal == complemento.Numcaixafiscal && nf.Docemissao == "CE").FirstOrDefault();
						if (pCNFSAID != null && pCNFSAID != null)
						{
							pCNFSAID.Tipoemissao = "9";
							pCNFSAID.Chavenfe = complemento.Chavenfce;
							pCNFSAID.Situacaonfe = complemento.Codstatus;
							pCNFSAID.Protocolonfe = complemento.Protocolonfce;
							pCNFSAID.Dthoraautorizacaosefaz = complemento.Dthoraautorizacaosefaz;
							_persistencia.Persistir(TipoPersistencia.ALTERAR, pCNFSAID);
						}
						PCPEDCECF _venda = _persistencia.CarregarLista(new PCPEDCECF(), (PCPEDCECF ped) => new { ped.Numtransvenda }, (PCPEDCECF nf) => (decimal?)nf.Numcaixa == complemento.Numcaixa && nf.Numcaixafiscal == complemento.Numcaixafiscal && nf.Codfilial == complemento.Codfilial && (decimal?)nf.Numpedecf == complemento.Numpedecf && nf.Docemissao == "CE").FirstOrDefault();
						if (_venda == null || _venda == null)
						{
							throw new Exception($"Não foi encontrada no banco de dados a venda referente ao complemento / Numpedecf: {complemento.Numpedecf}, Numcaixa: {complemento.Numcaixa}, Codfilial: {complemento.Codfilial}");
						}
						_venda.Tipoemissao = "9";
						_venda.Protocolonfce = complemento.Protocolonfce;
						_venda.Chavenfce = complemento.Chavenfce;
						_venda.Dthoraautorizacaosefaz = complemento.Dthoraautorizacaosefaz;
						_persistencia.Persistir(TipoPersistencia.ALTERAR, _venda);
						if (complemento.Xmlnfce != null && !string.IsNullOrEmpty(complemento.Xmlnfce) && complemento.Xmlnfce != "")
						{
							PCDOCELETRONICO pCDOCELETRONICO = _persistencia.CarregarLista(new PCDOCELETRONICO(), (PCDOCELETRONICO doc) => new { doc.Numtransacao }, (PCDOCELETRONICO nf) => (decimal?)nf.Numtransacao == _venda.Numtransvenda).FirstOrDefault();
							if (pCDOCELETRONICO == null || pCDOCELETRONICO == null)
							{
								PCDOCELETRONICO pCDOCELETRONICO2 = new PCDOCELETRONICO();
								pCDOCELETRONICO2.Numtransacao = _venda.Numtransvenda.GetValueOrDefault(0m);
								pCDOCELETRONICO2.Movimento = "S";
								pCDOCELETRONICO2.Xmlnfce = complemento.Xmlnfce;
								_persistencia.Persistir(TipoPersistencia.INCLUIR, pCDOCELETRONICO2);
							}
							else
							{
								pCDOCELETRONICO.Xmlnfce = complemento.Xmlnfce;
								_persistencia.Persistir(TipoPersistencia.ALTERAR, pCDOCELETRONICO);
							}
						}
					}
				}
				goto IL_081b;
				IL_081b:
				_persistencia.Persistir(TipoPersistencia.INCLUIR, complemento);
				_persistencia.FinalizarTransacao();
			}
			catch (Exception ex)
			{
				_persistencia.CancelarTransacao();
				_logImportacao.AppendLine($"Erro ao importar complemento NFC-e para o caixa {complemento.Numcaixa}: {ex.Message}");
			}
		}
	}

    private void ImportarDocEletronicoECF(List<PCDOCELETRONICOECF> listaDocEletronico)
	{
		foreach (PCDOCELETRONICOECF docEletronico in listaDocEletronico)
		{
			PCDOCELETRONICOECF pCDOCELETRONICOECF = _persistencia.CarregarLista(new PCDOCELETRONICOECF(), (PCDOCELETRONICOECF c) => c.Data == docEletronico.Data && c.Numcaixa == docEletronico.Numcaixa && c.Numpedecf == docEletronico.Numpedecf).ToList().FirstOrDefault();
			if (pCDOCELETRONICOECF == null || pCDOCELETRONICOECF == null)
			{
				_persistencia.Persistir(TipoPersistencia.INCLUIR, docEletronico);
			}
			else
			{
				if (docEletronico.Xmlnfce != null)
				{
					pCDOCELETRONICOECF.Xmlnfce = docEletronico.Xmlnfce;
				}
				if (docEletronico.Xmlnfcecancelamento != null)
				{
					pCDOCELETRONICOECF.Xmlnfcecancelamento = docEletronico.Xmlnfcecancelamento;
				}
				_persistencia.Persistir(TipoPersistencia.ALTERAR, pCDOCELETRONICOECF);
			}
			PCPEDCECF pCPEDCECF = _persistencia.CarregarLista(new PCPEDCECF(), (PCPEDCECF c) => (decimal?)c.Numpedecf == docEletronico.Numpedecf && (decimal?)c.Numcaixa == docEletronico.Numcaixa && c.Data == docEletronico.Data).FirstOrDefault();
			if (pCPEDCECF != null && pCPEDCECF != null)
			{
				GravarPCDOCELETRONICO(pCPEDCECF.Numtransvenda, docEletronico);
			}
		}
	}

    private void GravarPCDOCELETRONICO(decimal? numtransvenda, PCDOCELETRONICOECF item)
	{
		PCDOCELETRONICO pCDOCELETRONICO = _persistencia.CarregarLista(new PCDOCELETRONICO(), (PCDOCELETRONICO p) => (decimal?)p.Numtransacao == numtransvenda).FirstOrDefault();
		if (pCDOCELETRONICO != null && pCDOCELETRONICO != null)
		{
			if (item.Xmlnfce != null)
			{
				pCDOCELETRONICO.Xmlnfce = item.Xmlnfce;
			}
			if (item.Xmlnfcecancelamento != null)
			{
				pCDOCELETRONICO.Xmlnfcecancelamento = item.Xmlnfcecancelamento;
			}
			_persistencia.Persistir(TipoPersistencia.ALTERAR, pCDOCELETRONICO);
		}
		else
		{
			PCDOCELETRONICO pCDOCELETRONICO2 = new PCDOCELETRONICO();
			pCDOCELETRONICO2.Numtransacao = numtransvenda.GetValueOrDefault(0m);
			pCDOCELETRONICO2.Movimento = "S";
			pCDOCELETRONICO2.Xmlnfce = item.Xmlnfce;
			pCDOCELETRONICO2.Xmlnfcecancelamento = item.Xmlnfcecancelamento;
			_persistencia.Persistir(TipoPersistencia.INCLUIR, pCDOCELETRONICO2);
		}
	}

    private decimal ObterNumeroDeTransacao()
	{
		PCCONSUM pCCONSUM = new PCCONSUM();
		pCCONSUM = ParametrosDoSistema.ObterParametros(_persistencia);
		return _persistencia.ObterNumeroSequencialDeTabela(pCCONSUM, (PCCONSUM par) => par.Proxnumtrans);
	}

    private void CancelamentoAutomatico()
	{
		try
		{
			PCPEDCCANCECF cancelamento;
			PCPEDCECF venda;
			foreach (PCPEDCCANCECF item in _complemento.PCPEDCCANCECF.Where((PCPEDCCANCECF c) => (c.Tipocancel == "T" || c.Tipocancel == "A") && c.Cupomfechado != null && c.Cupomfechado == "S"))
			{
				cancelamento = item;
				LogFaturamento logFaturamento = new LogFaturamento(cancelamento.Numpedecf.ToString(), TipoLogFaturamento.Complemento);
				venda = null;
				int num = 0;
				while (venda == null && num < 6)
				{
					logFaturamento.Adicionar("Cancelamento de cupom, pesquisando a venda do cancelamento.");
					venda = _persistencia.CarregarLista(new PCPEDCECF(), (PCPEDCECF p) => p.Numpedecf == cancelamento.Numpedecf && p.Numcaixa == cancelamento.Numcaixa && p.Numcupom == cancelamento.Numcupom && p.Codfunccx == cancelamento.Codfunccx && p.Numserieequip.ToUpper() == cancelamento.Numserieequip.ToUpper()).FirstOrDefault();
					if (venda == null || venda == null)
					{
						logFaturamento.Adicionar("Cancelamento de cupom, não existe a venda, aguardando 5 segundos para a prox. tentativa.");
						Thread.Sleep(5000);
						num++;
						continue;
					}
					try
					{
						P_PC_CACELA_NF p_PC_CACELA_NF = new P_PC_CACELA_NF();
						logFaturamento.Adicionar("Validando se a procedure de cancelamento P_PC_CACELA_NF existe.");
						if (!_persistencia.ProcedureValidaExiste(p_PC_CACELA_NF))
						{
							_logImportacao.AppendLine("Erro ao processar cancelamentos de forma automática.");
							_logImportacao.AppendLine("Procedure de Cancelamento P_PC_CACELA_NF Inválida ou Inexistente, não foi possível realizar o cancelamento automático. {0} Realize a atualização da procedure através da rotina 2000.");
							throw new Exception("ERRO");
						}
						logFaturamento.Adicionar("Fim da validação da existencia da P_PC_CACELA_NF.");
						logFaturamento.Adicionar("Consultar usuario do Cancelamento.");
						PCEMPR pCEMPR = _persistencia.CarregarLista(new PCEMPR(), (PCEMPR nf) => new { nf.Nome_Guerra }, (PCEMPR nf) => nf.Matricula == cancelamento.Codfunccancelecf).FirstOrDefault();
						logFaturamento.Adicionar("Pesquisando nota do cancelamento na PCNFSAID.");
						PCNFSAID pCNFSAID = _persistencia.CarregarLista(new PCNFSAID(), (PCNFSAID nf) => new { nf.Numtransvenda, nf.Dtcancel }, (PCNFSAID nf) => (decimal?)nf.Numtransvenda == venda.Numtransvenda).FirstOrDefault();
						logFaturamento.Adicionar("Fim da pesquisa da nota do cancelamento na PCNFSAID.");
						if (pCNFSAID == null || pCNFSAID == null)
						{
							logFaturamento.Adicionar(string.Format("Numtrasnvenda: {0}, {1}", venda.Numtransvenda.ToString(), "Não foi possível encontrar o registro da PCNFSAID."));
						}
						if (pCNFSAID == null || pCNFSAID == null || !(pCNFSAID.Dtcancel.GetValueOrDefault() != default(DateTime)))
						{
							logFaturamento.Adicionar("Cancelamento de cupom, Preenchendo parametros da procedure, numtransvenda: " + pCNFSAID.Numtransvenda);
							p_PC_CACELA_NF.PNCODIGOFUNCIONARIO = pCEMPR.Nome_Guerra;
							p_PC_CACELA_NF.PNNUMTRANSVENDA = pCNFSAID.Numtransvenda;
							p_PC_CACELA_NF.PVC2MOTIVOCANCEL = "CANCELAMENTO AUTOMATICO";
							logFaturamento.Adicionar("Cancelamento de cupom, chamando procedure para cancelar o cupom.");
							_persistencia.ExecutarProcedure(p_PC_CACELA_NF);
							if (!string.IsNullOrEmpty(p_PC_CACELA_NF.PVC2MENSSAGEM) && !p_PC_CACELA_NF.PVC2MENSSAGEM.Contains("OK"))
							{
								throw new Exception(p_PC_CACELA_NF.PVC2MENSSAGEM);
							}
							pCNFSAID.Situacaonfe = 101;
							_persistencia.Persistir(TipoPersistencia.ALTERAR, pCNFSAID);
							logFaturamento.Adicionar("INICIO - Recalculo Estoque");
							InserirRecalculoDeHistoricoDeEstoque(venda, cancelamento);
							logFaturamento.Adicionar("FIM - Recalculo Estoque");
							logFaturamento.Adicionar("Cancelamento de cupom, fim do processamento da procedure.");
							logFaturamento.Adicionar($"Numtransvenda: {pCNFSAID.Numtransvenda}, Retorno: {p_PC_CACELA_NF.PVC2MENSSAGEM}.");
							logFaturamento.Adicionar($"FIM    - FINALIZARTRANSACAO A TRANSACAO ESTÁ ABERTA ? {_persistencia.TransacaoAberta}");
							logFaturamento.Gravar();
						}
					}
					catch (Exception ex)
					{
						logFaturamento.GravarExcecao(ex);
						throw ex;
					}
				}
				if (venda == null || venda == null)
				{
					Exception ex2 = new Exception(Environment.NewLine + $"Venda com numpedecf: {cancelamento.Numpedecf} não encontrada para a aplicação do cancelamento ," + Environment.NewLine + "Aguarde a venda ser processada, para uma nova tentativa de importação do cancelamento." + Environment.NewLine + "Poderá ser feito o reprocessamento do arquivo em 'Arquivos Rejeitados', ou aguardar que o PDV reenvie o cancelamento de forma automática" + Environment.NewLine);
					logFaturamento.GravarExcecao(ex2);
					throw ex2;
				}
			}
            
		}

        
		catch (Exception ex3)
		{
			int num2 = new Random().Next(100000);
			new LogFaturamento($"COMPLE_{num2}", TipoLogFaturamento.Processamento).GravarExcecao(ex3);
			throw;
		}
	}

    private void InserirRecalculoDeHistoricoDeEstoque(PCPEDCECF venda, PCPEDCCANCECF cancelamento)
	{
		try
		{
			if (!(cancelamento.Data < DateTime.Now.Date))
			{
				return;
			}
			foreach (PCPEDIECF item in _persistencia.CarregarLista(new PCPEDIECF(), (PCPEDIECF p) => p.Numpedecf == venda.Numpedecf && p.Data == venda.Data && p.Codfunccx == venda.Codfunccx && p.Numserieequip == venda.Numserieequip && p.Numcaixa == venda.Numcaixa).ToList())
			{
				PCRECALCULOPROD pCRECALCULOPROD = _persistencia.CarregarLista(new PCRECALCULOPROD(), (PCRECALCULOPROD prod) => prod.Codfilial == item.Codfilial && prod.Numtransvenda == venda.Numtransvenda && prod.Codprod == item.Codprod && prod.Tiporegistro == "C").FirstOrDefault();
				if (pCRECALCULOPROD != null && pCRECALCULOPROD != null)
				{
					pCRECALCULOPROD.Qt += (decimal?)item.Qt;
					_persistencia.Persistir(TipoPersistencia.ALTERAR, pCRECALCULOPROD);
					continue;
				}
				PCRECALCULOPROD pCRECALCULOPROD2 = new PCRECALCULOPROD();
				pCRECALCULOPROD2.Codfilial = item.Codfilial;
				pCRECALCULOPROD2.Codprod = item.Codprod;
				pCRECALCULOPROD2.Numtransvenda = venda.Numtransvenda;
				pCRECALCULOPROD2.Qt = item.Qt;
				pCRECALCULOPROD2.Dtinclusao = DateTime.Now.Date;
				pCRECALCULOPROD2.Dtrecalculo = item.Data;
				pCRECALCULOPROD2.Tiporegistro = "C";
				_persistencia.Persistir(TipoPersistencia.INCLUIR, pCRECALCULOPROD2);
			}
		}
		catch (Exception ex)
		{
			_persistencia.CancelarTransacao();
			throw new Exception(ex.Message);
		}
	}


}

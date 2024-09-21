using nwErp.Api.Entidades;
using nwErp.Api.Utilidades;
using nwErp.Api.Persistencia;
using nwErp.Api.Definicoes;

namespace nwErp.Api.Importadores;

public class ImportadorBase
{

    private LogImportacao<PCPEDCECF> _logImportacao;

	private static readonly object _objectLock = new object();

	protected LogFaturamento logFat;

	protected IPersistencia Persistencia { get; private set; }

	protected DefinicaoPedidoECF DefinicaoPedido { get; private set; }

	public void Importar(DefinicaoPedidoECF pedido, IPersistencia persistencia)
	{
		Persistencia = persistencia;
		DefinicaoPedido = pedido;
		if (DefinicaoPedido.Pedido.Serieecf == "X" || DefinicaoPedido.Pedido.Docemissao != "NF")
		{
			logFat = new LogFaturamento(DefinicaoPedido.Pedido.Numpedecf + "_" + Thread.CurrentThread.ManagedThreadId, TipoLogFaturamento.Cupom);
		}
		else
		{
			logFat = new LogFaturamento(DefinicaoPedido.Pedido.Numpedecf + "_" + Thread.CurrentThread.ManagedThreadId, TipoLogFaturamento.Nota);
		}
		logFat.Adicionar($"Importanado pedido {DefinicaoPedido.Pedido.Numped} : {Thread.CurrentThread.ManagedThreadId}");
		GerarXMLDoPacote();
		PrepararGeracaoDeLog();
		TratarRegistros();
		Importar();
	}

	protected void RegistrarLog(string log)
	{
		_logImportacao.RegistrarLinha($"[{DateTime.Now}] {log}");
	}

	private void PrepararGeracaoDeLog()
	{
		_logImportacao = new LogImportacao<PCPEDCECF>(Persistencia, DefinicaoPedido.Pedido.Numpedecf, 0m, DefinicaoPedido.Pedido.Numcaixa, 0m, DefinicaoPedido.Pedido.Numserieequip, DefinicaoPedido.Pedido.Codfunccx);
	}

	protected virtual void TratarRegistros()
	{
		DefinicaoPedido.Pedido.Condvenda = 1;
		DefinicaoPedido.Pedido.Percvenda = 100;
		DefinicaoPedido.Pedido.Exportado = "S";
		DefinicaoPedido.Pedido.Versaofaturamento = VersaoFaturamento.VersaoAtual;
		if (DefinicaoPedido.Pedido.Vlsubtotal.HasValue)
		{
			decimal? vlsubtotal = DefinicaoPedido.Pedido.Vlsubtotal;
			if ((vlsubtotal.GetValueOrDefault() > default(decimal)) & vlsubtotal.HasValue)
			{
				decimal num = Math.Abs(DefinicaoPedido.Pedido.Vlsubtotal.GetValueOrDefault(0m) - DefinicaoPedido.Pedido.Vltotal.GetValueOrDefault(0m));
				decimal num2 = Convert.ToDecimal(0.01 * (double)DefinicaoPedido.Itens.Count);
				if (num <= num2)
				{
					DefinicaoPedido.Pedido.Vltotal = DefinicaoPedido.Pedido.Vlsubtotal;
					DefinicaoPedido.Pedido.Vlatend = DefinicaoPedido.Pedido.Vlsubtotal;
				}
			}
		}
		if (DefinicaoPedido.Itens == null || DefinicaoPedido.Itens.Count == 0)
		{
			throw new Exception($"Erro - Arquivo XML Inconsistente Não existem Itens - Numpedecf do Cabecalho: {DefinicaoPedido.Pedido.Numpedecf} - Numcaixa {DefinicaoPedido.Pedido.Numcaixa}");
		}
		foreach (PCPEDIECF iten in DefinicaoPedido.Itens)
		{
			iten.Posicao = DefinicaoPedido.Pedido.Posicao;
			iten.Numcar = DefinicaoPedido.Pedido.Numcar;
			iten.Numped = DefinicaoPedido.Pedido.Numped;
			iten.Importado = DefinicaoPedido.Pedido.Importado;
			iten.Exportado = DefinicaoPedido.Pedido.Exportado;
			if (iten.Pbaserca.HasValue)
			{
				decimal? vlsubtotal = iten.Pbaserca;
				if (!((vlsubtotal.GetValueOrDefault() == default(decimal)) & vlsubtotal.HasValue))
				{
				}
			}
			iten.Pbaserca = iten.Ptabela;
			if (DefinicaoPedido.Pedido.Docemissao != null && DefinicaoPedido.Pedido.Docemissao == "CF")
			{
				iten.Codecf = CorrigirVD.FormatarCODECF(iten.Codecf);
				iten.Sittribut = CorrigirVD.ObterSittribut(iten.Codecf, iten.Sittribut);
				iten.Percicm = CorrigirVD.ObterPercICMS(iten.Codecf);
			}
			if (iten.Numpedecf != DefinicaoPedido.Pedido.Numpedecf || iten.Numcaixa != DefinicaoPedido.Pedido.Numcaixa)
			{
				throw new Exception($"Erro - Arquivo XML Inconsistente\r\n                                                           -> CABEÇALHO - Numpedecf: {DefinicaoPedido.Pedido.Numpedecf} - Numcaixa: {DefinicaoPedido.Pedido.Numcaixa}\r\n                                                            -> ITENS - Numpedecf: {iten.Numpedecf} - Numcaixa: {iten.Numcaixa}");
			}
		}
		foreach (PCPEDIECFCESTA itensCestum in DefinicaoPedido.ItensCesta)
		{
			itensCestum.Numped = DefinicaoPedido.Pedido.Numped;
			itensCestum.Importado = DefinicaoPedido.Pedido.Importado;
			itensCestum.Exportado = DefinicaoPedido.Pedido.Exportado;
		}
		foreach (PCORIGEMPRECOECF item2 in DefinicaoPedido.OrigemDePreco)
		{
			item2.Importado = DefinicaoPedido.Pedido.Importado;
			item2.Exportado = DefinicaoPedido.Pedido.Exportado;
		}
		foreach (PCAUTORIECF item in DefinicaoPedido.Autorizacao)
		{
			if (Persistencia.ContarRegistros<PCAUTORIECF>((PCAUTORIECF autori) => autori.Nrautorizacaoecf == item.Nrautorizacaoecf && autori.Numpedecf == item.Numpedecf && autori.Codfunccx == item.Codfunccx && autori.Numcaixa == item.Numcaixa && autori.Serieequip == item.Serieequip && autori.Dataautorizacao == item.Dataautorizacao) == 0)
			{
				item.Numped = DefinicaoPedido.Pedido.Numped;
				item.Importado = DefinicaoPedido.Pedido.Importado;
				item.Exportado = DefinicaoPedido.Pedido.Exportado;
			}
			else
			{
				item.PosicaoEntidade = PosicaoEntidade.Excluida;
			}
		}
		DefinicaoPedido.Autorizacao = DefinicaoPedido.Autorizacao.Where((PCAUTORIECF autori) => autori.PosicaoEntidade != PosicaoEntidade.Excluida).ToList();
		if (DefinicaoPedido.Parcelas == null || DefinicaoPedido.Parcelas.Count == 0)
		{
			throw new Exception($"Erro - Arquivo XML Inconsistente Não existem Parcelas (PCPRESTECF) - Numpedecf do Cabecalho: {DefinicaoPedido.Pedido.Numpedecf} - Numcaixa {DefinicaoPedido.Pedido.Numcaixa}");
		}
		foreach (PCPRESTECF parcela in DefinicaoPedido.Parcelas)
		{
			parcela.Numped = DefinicaoPedido.Pedido.Numped;
			parcela.Numtransvenda = DefinicaoPedido.Pedido.Numtransvenda;
			parcela.Importado = DefinicaoPedido.Pedido.Importado;
			parcela.Exportado = DefinicaoPedido.Pedido.Exportado;
			if (parcela.Numpedecf != DefinicaoPedido.Pedido.Numpedecf || parcela.Numcheckout != DefinicaoPedido.Pedido.Numcaixa)
			{
				throw new Exception($"Erro - Arquivo XML Inconsistente\r\n                                                           -> CABEÇALHO - Numpedecf: {DefinicaoPedido.Pedido.Numpedecf} - Numcaixa: {DefinicaoPedido.Pedido.Numcaixa}\r\n                                                            -> PCPRESTECF - Numpedecf: {parcela.Numpedecf} - Numcaixa: {parcela.Numcheckout}");
			}
		}
		foreach (PCVENDACONSUMECF item3 in DefinicaoPedido.ConsumidorFinal)
		{
			item3.Numped = DefinicaoPedido.Pedido.Numped;
			item3.Importado = DefinicaoPedido.Pedido.Importado;
			item3.Exportado = DefinicaoPedido.Pedido.Exportado;
		}
		foreach (PCDOCELETRONICOECF item4 in DefinicaoPedido.DocumentoEletronico)
		{
			item4.Numtransvenda = DefinicaoPedido.Pedido.Numtransvenda;
			item4.Exportado = DefinicaoPedido.Pedido.Exportado;
		}
		if (DefinicaoPedido.HistoricoMotorOferta != null && DefinicaoPedido.HistoricoMotorOferta.Numpedecf > 0m)
		{
			DefinicaoPedido.HistoricoMotorOferta.Numtransvenda = DefinicaoPedido.Pedido.Numtransvenda;
			DefinicaoPedido.HistoricoMotorOferta.Exportado = DefinicaoPedido.Pedido.Exportado;
		}
	}

	protected virtual void Importar()
	{
		Persistencia.IniciarTransacao();
		try
		{
			logFat.Adicionar(string.Format("Inicio Importar {0}", DefinicaoPedido.Pedido.Numped, Thread.CurrentThread.ManagedThreadId));
			logFat.Adicionar($"-> Thread: {Thread.CurrentThread.ManagedThreadId}.");
			logFat.Adicionar("INICIANDO IMPORTAÇÃO DE TABELAS ECF E ADICIONAIS");
			logFat.Adicionar("INICIO - IMPORTAR PCPEDCECF NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			Persistencia.Persistir(TipoPersistencia.INCLUIR, DefinicaoPedido.Pedido);
			logFat.Adicionar("FIM    - IMPORTAR PCPEDCECF");
			logFat.Adicionar("INICIO - IMPORTAR ITENS NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			IncluirLista(DefinicaoPedido.Itens);
			logFat.Adicionar("FIM    - IMPORTAR ITENS");
			logFat.Adicionar("INICIO - IMPORTAR ITENS CESTA NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			IncluirLista(DefinicaoPedido.ItensCesta);
			logFat.Adicionar("FIM    - IMPORTAR ITENS CESTA");
			logFat.Adicionar("INICIO - IMPORTAR PARCELAS NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			IncluirLista(DefinicaoPedido.Parcelas);
			logFat.Adicionar("FIM    - IMPORTAR PARCELAS");
			logFat.Adicionar("INICIO - IMPORTAR CONSUMIDOR FINAL NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			IncluirLista(DefinicaoPedido.ConsumidorFinal);
			logFat.Adicionar("FIM    - IMPORTAR CONSUMIDOR FINAL");
			logFat.Adicionar("INICIO - IMPORTAR ORIGEM PRECO NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			IncluirLista(DefinicaoPedido.OrigemDePreco);
			logFat.Adicionar("FIM    - IMPORTAR ORIGEM PRECO");
			logFat.Adicionar("INICIO - IMPORTAR AUTORIZACAO NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			IncluirLista(DefinicaoPedido.Autorizacao);
			logFat.Adicionar("FIM    - IMPORTAR AUTORIZACAO");
			logFat.Adicionar("INICIO - IMPORTAR DOCELETRONICO NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			IncluirLista(DefinicaoPedido.DocumentoEletronico);
			logFat.Adicionar("FIM    - IMPORTAR DOCELETRONICO");
			if (DefinicaoPedido.HistoricoMotorOferta != null && DefinicaoPedido.HistoricoMotorOferta.Numpedecf > 0m)
			{
				logFat.Adicionar("INICIO - IMPORTAR PCHISTORICOSMOTOROFERTA NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
				Persistencia.Persistir(TipoPersistencia.INCLUIR, DefinicaoPedido.HistoricoMotorOferta);
				logFat.Adicionar("FIM    - IMPORTAR PCHISTORICOSMOTOROFERTA");
			}
			if (DefinicaoPedido.EnderecoEntrega != null && DefinicaoPedido.EnderecoEntrega.Count > 0)
			{
				if (!DefinicaoPedido.EnderecoEntrega.FirstOrDefault().Dataentrega.HasValue)
				{
					try
					{
						logFat.Adicionar("DATA ENTREGA NULL");
						File.AppendAllText("LOG_DATAENTREGA.txt", "Data de entrega NULL - NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf + " NUMCAIXA: " + DefinicaoPedido.Pedido.Numcaixa + Environment.NewLine);
					}
					catch (Exception)
					{
					}
				}
				logFat.Adicionar("INICIO - IMPORTAR PCENDERECODELIVERY NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
				IncluirLista(DefinicaoPedido.EnderecoEntrega);
				logFat.Adicionar("FIM    - IMPORTAR PCENDERECODELIVERY");
			}
			logFat.Adicionar("INICIO -  EXECUTARPROCESSOSADICIONAISEFINALIZAR");
			ExecutarProcessosAdicionaisEFinalizar();
			logFat.Adicionar("FIM    -  EXECUTARPROCESSOSADICIONAISEFINALIZAR");
			logFat.Adicionar("INICIO - IMPORTAR RECALCULO DE HISTORICO DE ESTOQUE NUMPEDECF: " + DefinicaoPedido.Pedido.Numpedecf);
			InserirRecalculoDeHistoricoDeEstoque();
			logFat.Adicionar("FIM    - IMPORTAR RECALCULO DE HISTORICO DE ESTOQUE");
			logFat.Adicionar($"INICIO - FINALIZARTRANSACAO A TRANSACAO ESTÁ ABERTA ? {Persistencia.TransacaoAberta}");
			Persistencia.FinalizarTransacao();
			logFat.Adicionar($"FIM    - FINALIZARTRANSACAO A TRANSACAO ESTÁ ABERTA ? {Persistencia.TransacaoAberta}");
			_logImportacao.FinalizadoComSucesso = true;
			logFat.Gravar();
			logFat.Adicionar(string.Format("Fim Importar : {0}", DefinicaoPedido.Pedido.Numped, Thread.CurrentThread.ManagedThreadId));
		}
		catch (Exception ex2)
		{
			Persistencia.CancelarTransacao();
			_logImportacao.FinalizadoComSucesso = false;
			GravarLog("Erro ao gravar pedido: " + ex2.Message);
			logFat.GravarExcecao(ex2);
			throw new Exception(ex2.Message);
		}
	}

	private void GravarLog(string mensagem)
	{
		_logImportacao.RegistrarLinha();
		_logImportacao.RegistrarLinha();
		_logImportacao.RegistrarLinha(mensagem);
		_logImportacao.Gravar();
	}

	protected virtual void ExecutarProcessosAdicionaisEFinalizar()
	{
	}

	protected void InserirRecalculoDeHistoricoDeEstoque()
	{
		if (DefinicaoPedido.Itens == null || !(DefinicaoPedido.Pedido.Data < DateTime.Now.Date))
		{
			return;
		}
		foreach (PCPEDIECF item in DefinicaoPedido.Itens)
		{
			PCRECALCULOPROD pCRECALCULOPROD = Persistencia.CarregarLista(new PCRECALCULOPROD(), (PCRECALCULOPROD prod) => prod.Codfilial == item.Codfilial && prod.Codprod == item.Codprod && prod.Tiporegistro == "V" && prod.Numtransvenda == DefinicaoPedido.Pedido.Numtransvenda).FirstOrDefault();
			if (pCRECALCULOPROD != null && pCRECALCULOPROD != null)
			{
				pCRECALCULOPROD.Qt += (decimal?)item.Qt;
				Persistencia.Persistir(TipoPersistencia.ALTERAR, pCRECALCULOPROD);
				continue;
			}
			PCRECALCULOPROD pCRECALCULOPROD2 = new PCRECALCULOPROD();
			pCRECALCULOPROD2.Codfilial = item.Codfilial;
			pCRECALCULOPROD2.Codprod = item.Codprod;
			pCRECALCULOPROD2.Numtransvenda = DefinicaoPedido.Pedido.Numtransvenda;
			pCRECALCULOPROD2.Qt = item.Qt;
			pCRECALCULOPROD2.Dtinclusao = DateTime.Now.Date;
			pCRECALCULOPROD2.Dtrecalculo = item.Data;
			pCRECALCULOPROD2.Tiporegistro = "V";
			Persistencia.Persistir(TipoPersistencia.INCLUIR, pCRECALCULOPROD2);
		}
	}

	protected void IncluirLista<T>(List<T> lista) where T : IEntidade
	{
		try
		{
			RegistrarLog("Incluindo " + lista.Count + " registros na tabela " + typeof(T).Name);
		}
		catch
		{
		}
		foreach (T listum in lista)
		{
			try
			{
				Persistencia.Persistir(TipoPersistencia.INCLUIR, listum);
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("PCVENDACONSUMECF_PK"))
				{
					Persistencia.Persistir(TipoPersistencia.ALTERAR, listum);
				}
			}
		}
	}

	private void GerarXMLDoPacote()
	{
		DefinicaoPedido.XMLPacote = SerializarParaString(DefinicaoPedido);
	}

	private string SerializarParaString(object obj)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
		using StringWriter stringWriter = new StringWriter();
		xmlSerializer.Serialize(stringWriter, obj);
		return stringWriter.ToString();
	}

	public bool ObterParametroBoolean(string nomeparametro)
	{
		try
		{
			return ObterParametroBoolean(nomeparametro, "99");
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool ObterParametroBoolean(string nomeparametro, string codfilial)
	{
		PARAMFILIAL.OBTERCOMOBOOLEAN oBTERCOMOBOOLEAN = new PARAMFILIAL.OBTERCOMOBOOLEAN();
		oBTERCOMOBOOLEAN.NOMEPARAM = nomeparametro.ToUpper();
		oBTERCOMOBOOLEAN.CODFILIAL = "99";
		Persistencia.ExecutarProcedure(oBTERCOMOBOOLEAN);
		if (!string.IsNullOrEmpty(oBTERCOMOBOOLEAN.Retorno))
		{
			return oBTERCOMOBOOLEAN.Retorno.ToUpper().Contains("S");
		}
		return false;
	}

	public string ObterParametroString(string nomeparametro)
	{
		return ObterParametroString(nomeparametro, "99");
	}

	public string ObterParametroString(string nomeparametro, string codfilial)
	{
		PARAMFILIAL.OBTERCOMOVARCHAR2 oBTERCOMOVARCHAR = new PARAMFILIAL.OBTERCOMOVARCHAR2();
		oBTERCOMOVARCHAR.NOMEPARAM = nomeparametro;
		oBTERCOMOVARCHAR.PCODFILIAL = "99";
		Persistencia.ExecutarProcedure(oBTERCOMOVARCHAR);
		return oBTERCOMOVARCHAR.Retorno;
	}

}

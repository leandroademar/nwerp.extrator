using System.Text;
using nwErp.Api.Definicoes;
using nwErp.Api.Persistencia;

namespace nwErp.Api.Entidades;

[Serializable]
public sealed class EsquemaExportacao
{
	private OrigemDeDados _origemDeDados;

	private DefinicaoPedidoECF _pedido;

	private DefinicaoNotaFiscal _pedidoNota;

	private DefinicaoComplemento _complemento;


	public OrigemDeDados OrigemDeDados
	{
		get
		{
			return _origemDeDados;
		}
		set
		{
			_origemDeDados = value;
		}
	}

	public decimal Numcaixa { get; set; }

	public DefinicaoPedidoECF Pedido
	{
		get
		{
			if (_pedido == null)
			{
				_pedido = new DefinicaoPedidoECF();
			}
			return _pedido;
		}
		set
		{
			_pedido = value;
		}
	}

	public DefinicaoNotaFiscal PedidoNota
	{
		get
		{
			if (_pedidoNota == null)
			{
				_pedidoNota = new DefinicaoNotaFiscal();
			}
			return _pedidoNota;
		}
		set
		{
			_pedidoNota = value;
		}
	}

	public DefinicaoComplemento Complemento
	{
		get
		{
			if (_complemento == null)
			{
				_complemento = new DefinicaoComplemento();
			}
			return _complemento;
		}
		set
		{
			_complemento = value;
		}
	}



	[XmlIgnore]
	public bool PedidoExportado
	{
		get
		{
			if (_pedido != null)
			{
				return _pedido.Pedido != null;
			}
			return false;
		}
	}

	[XmlIgnore]
	public bool PedidoNotaExportado
	{
		get
		{
			if (_pedidoNota != null && _pedidoNota.Pedido != null && _pedidoNota.DefinicaoPedidoECF != null && _pedidoNota.DefinicaoPedidoECF.Pedido != null && _pedidoNota.Nota != null)
			{
				return _pedidoNota.Nota.Numtransvenda != 0m;
			}
			return false;
		}
	}

	[XmlIgnore]
	public bool ComplementoExportado
	{
		get
		{
			if (_complemento != null)
			{
				return _complemento.PossuiRegistros;
			}
			return false;
		}
	}


	public EsquemaExportacao()
	{
	}

	public EsquemaExportacao(OrigemDeDados origemDeDados)
	{
		_origemDeDados = origemDeDados;
	}

	public static EsquemaExportacao LerDeArquivo(string nomeDoArquivo)
	{
		EsquemaExportacao result = null;
		if (File.Exists(nomeDoArquivo))
		{
			string text = FuncoesDeArquivo.ObterConteudoDoArquivo(nomeDoArquivo);
			try
			{
				result = Serializador.Deserializar<EsquemaExportacao>(text);
			}
			catch (Exception ex)
			{
				if (ex.Message.ToString().Contains("Erro no documento XML"))
				{
					string[] array = text.Split('\n');
					string[] array2 = ex.Message.Replace("Erro no documento XML (", "").Replace(")", "").Replace(".", "")
						.Trim()
						.Split(',');
					throw new Exception($"{ex.Message.ToString()}{Environment.NewLine}Linha do XML com Erro:{array[Convert.ToInt32(array2[0]) - 1]}{Environment.NewLine}Verifique a linha {array2[0]} diretamente no XML.");
				}
				throw new Exception(ex.Message.ToString());
			}
		}
		return result;
	}

	public static EsquemaExportacao LerDeConteudo(string conteudoArquivo)
	{
		EsquemaExportacao esquemaExportacao = null;
		try
		{
			return Serializador.Deserializar<EsquemaExportacao>(conteudoArquivo);
		}
		catch (Exception ex)
		{
			if (ex.Message.ToString().Contains("Erro no documento XML"))
			{
				string[] array = conteudoArquivo.Split('\n');
				string[] array2 = ex.Message.Replace("Erro no documento XML (", "").Replace(")", "").Replace(".", "")
					.Trim()
					.Split(',');
				string text = array[int.Parse(array2[0]) - 1].ToString().Substring(int.Parse(array2[1].Trim()) - 15, 30);
				throw new Exception(ex.Message.ToString() + Environment.NewLine + "Parte do XML com erro: " + text + Environment.NewLine + "Obs.: Verifique a String exibida acima diretamente no XML.");
			}
			throw new Exception(ex.Message.ToString());
		}
	}

	public void SalvarParaArquivo(string nomeDoArquivo)
	{
		string contents = Serializador.Serializar(this);
		if (File.Exists(nomeDoArquivo))
		{
			File.Delete(nomeDoArquivo);
		}
		File.WriteAllText(nomeDoArquivo, contents, Encoding.Default);
	}
}
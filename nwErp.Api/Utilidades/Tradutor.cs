using System.Globalization;
using System.Xml;

//namespace nwErp.Utilidades;

public class Tradutor : IDisposable
{
	public class Sentenca
	{
		public string Nome { get; set; }

		public string Valor { get; set; }

		public Sentenca()
		{
		}

		public Sentenca(string nome, string valor)
		{
			Nome = nome;
			Valor = valor;
		}
	}

	private const string _prefixoDoArquivoDeSentencaNaoTraduzida = "ntrdzd.";

	private const string _valorNaoEncontrado = "[- Valor não encontrado -]";

	private const string _arquivoNaoEncontrado = "[- Arquivo de sentenças não encontrado! -]";

	private const string _idiomaPadrao = "pt-BR";

	private const string _extensaoArquivoSentenca = ".xml";

	private string _diretorioDeArquivo;

	private string _idiomaDefinido;

	public string ArquivoDeSentencasNaoTraduzidasPadrao => MontarNomeArquivo("pt-BR", "ntrdzd.");

	public string ArquivoDeSentencasNaoTraduzidas => MontarNomeArquivo(_idiomaDefinido, "ntrdzd.");

	public string ArquivoDeSentencasPadrao => MontarNomeArquivo("pt-BR", string.Empty);

	public string ArquivoDeSentencas => MontarNomeArquivo(_idiomaDefinido, string.Empty);

	public Tradutor(string diretorioDeArquivo, string idioma)
	{
		_diretorioDeArquivo = diretorioDeArquivo;
		if (idioma == string.Empty)
		{
			_idiomaDefinido = CultureInfo.CurrentCulture.Name;
		}
		else
		{
			_idiomaDefinido = idioma;
		}
	}

	private string MontarNomeArquivo(string idioma, string prefixo)
	{
		return _diretorioDeArquivo + "\\" + prefixo + idioma + ".xml";
	}

	public string ObterSentencaPeloValor(string valor)
	{
		if (_idiomaDefinido == "pt-BR")
		{
			return valor;
		}
		string text = ObterSentencaPeloIndiceDefinido(ArquivoDeSentencasPadrao, "Valor", "Nome", valor);
		string text2 = valor;
		if (!RegistrarChaveNaoEncontrada(ArquivoDeSentencasNaoTraduzidasPadrao, text, text2))
		{
			text2 = ObterSentencaPeloIndiceDefinido(ArquivoDeSentencas, "Nome", "Valor", text);
		}
		if (text2 == "[- Valor não encontrado -]")
		{
			text2 = $"#{valor}#";
			RegistrarInformacaoNaoEncontrada(ArquivoDeSentencasNaoTraduzidas, text, valor);
		}
		return text2;
	}

	public string ObterSentencaPelaChave(string chave, string valorPadrao)
	{
		string text = ObterSentencaPeloIndiceDefinido(ArquivoDeSentencas, "Nome", "Valor", chave);
		if (text == "[- Valor não encontrado -]")
		{
			RegistrarInformacaoNaoEncontrada(ArquivoDeSentencasNaoTraduzidas, chave, valorPadrao);
		}
		if (_idiomaDefinido == "pt-BR" && (text == "[- Valor não encontrado -]" || text == "[- Arquivo de sentenças não encontrado! -]") && !string.IsNullOrEmpty(valorPadrao))
		{
			text = $"#{valorPadrao}#";
		}
		return text;
	}

	private string ObterSentencaPeloIndiceDefinido(string arquivoDeSentencas, string elementoIndice, string elementoRetorno, string valorComparacao)
	{
		string result = "[- Valor não encontrado -]";
		if (File.Exists(ArquivoDeSentencas))
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.PreserveWhitespace = false;
			if (File.Exists(arquivoDeSentencas))
			{
				xmlDocument.Load(arquivoDeSentencas);
			}
			else
			{
				xmlDocument.CreateXmlDeclaration("1.0", string.Empty, string.Empty);
				xmlDocument.AppendChild(xmlDocument.CreateElement("ArrayOfChaveSentenca"));
			}
			XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode("descendant::ChaveSentenca[" + elementoIndice + "=\"" + valorComparacao + "\"]");
			if (xmlNode != null)
			{
				xmlNode = xmlNode.SelectSingleNode("descendant::" + elementoRetorno);
				if (xmlNode != null)
				{
					result = xmlNode.InnerText;
				}
			}
		}
		else
		{
			ObterArquivoPeloNome(arquivoDeSentencas);
		}
		return result;
	}

	private bool RegistrarChaveNaoEncontrada(string nomeDoArquivo, string chave, string valor)
	{
		if (chave == "[- Valor não encontrado -]")
		{
			RegistrarInformacaoNaoEncontrada(nomeDoArquivo, chave, valor);
			return true;
		}
		return false;
	}

	private void RegistrarInformacaoNaoEncontrada(string nomeDoArquivo, string chave, string valor)
	{
		XmlDocument xmlDocument = ObterArquivoPeloNome(nomeDoArquivo);
		XmlElement documentElement = xmlDocument.DocumentElement;
		XmlNode xmlNode = ((!(chave != string.Empty)) ? documentElement.SelectSingleNode("descendant::ChaveSentenca[Valor=\"" + valor + "\"]") : documentElement.SelectSingleNode("descendant::ChaveSentenca[Nome=\"" + chave + "\"]"));
		if (xmlNode == null)
		{
			XmlElement xmlElement = xmlDocument.CreateElement("ChaveSentenca");
			XmlElement xmlElement2 = xmlDocument.CreateElement("Nome");
			XmlElement xmlElement3 = xmlDocument.CreateElement("Valor");
			xmlElement3.InnerText = valor;
			xmlElement2.InnerText = chave;
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			documentElement.AppendChild(xmlElement);
			xmlDocument.Save(nomeDoArquivo);
		}
	}

	private static XmlDocument ObterArquivoPeloNome(string nomeDoArquivo)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.PreserveWhitespace = false;
		if (File.Exists(nomeDoArquivo))
		{
			xmlDocument.Load(nomeDoArquivo);
		}
		else
		{
			xmlDocument.CreateXmlDeclaration("1.0", string.Empty, string.Empty);
			xmlDocument.AppendChild(xmlDocument.CreateElement("ArrayOfChaveSentenca"));
		}
		return xmlDocument;
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
	}
}

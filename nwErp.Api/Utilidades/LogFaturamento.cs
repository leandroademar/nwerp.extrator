public class LogFaturamento
{
	private string chave;

	private TipoLogFaturamento tipoDeLogImportacao;

	public LogFaturamento(string identificador, TipoLogFaturamento tipoLog)
	{
		chave = identificador;
		tipoDeLogImportacao = tipoLog;
	}

	private string ObterNomeArquivo(string identificador, TipoLogFaturamento tipoLog)
	{

        string prefixo;

            switch (tipoLog)
            {
                case TipoLogFaturamento.Cupom:
                    prefixo = "IMPORTACAOCUPOM";
                    break;
                case TipoLogFaturamento.Complemento:
                    prefixo = "IMPORTACAOCOMPLEMENTO";
                    break;
                case TipoLogFaturamento.Persistencia:
                    prefixo = "PERSISTENCIA";
                    break;
                case TipoLogFaturamento.Processamento:
                    prefixo = "PROCESSAMENTO";
                    break;
                case TipoLogFaturamento.Nota:
                    prefixo = "IMPORTACAONOTA";
                    break;
                default:
                    prefixo = "IMPORTACAO";
                    break;
            }

            return string.Format("{0}_{1}", prefixo, identificador);
        
    }

	public void Adicionar(string conteudo)
	{
		LogDebug.Adicionar(chave, conteudo);
	}

	public void GravarExcecao(Exception ex)
	{
		string nomeArquivo = ObterNomeArquivo(chave, tipoDeLogImportacao);
		LogDebug.GravarExcecao(chave, nomeArquivo, ex);
	}

	public void Gravar()
	{
		LogDebug.Gravar(ObterNomeArquivo(chave, tipoDeLogImportacao), chave);
	}
}

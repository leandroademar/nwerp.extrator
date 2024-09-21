//namespace nwErp.Utilidades;

public static class LogInstrumentado
{
	public static string NomeCompletoArquivo { get; set; }

	public static void DefinirNomeCompletoArquivo(string nomeCompleto)
	{
		TratarLocalDestinoLog(nomeCompleto);
		NomeCompletoArquivo = nomeCompleto;
	}

	private static void TratarLocalDestinoLog(string nomeCompleto)
	{
		string directoryName = Path.GetDirectoryName(nomeCompleto);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
	}

	public static void Escrever(string mensagem)
	{
		if (LogDebug.Ativo && !string.IsNullOrEmpty(NomeCompletoArquivo) && !string.IsNullOrEmpty(mensagem))
		{
			File.AppendAllText(NomeCompletoArquivo, string.Format("{0} #> {1}{2}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:fff"), mensagem, Environment.NewLine));
		}
	}
}

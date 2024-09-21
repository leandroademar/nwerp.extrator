using System.Runtime.InteropServices;
using System.Text;

//namespace nwErp.Utilidades;

public static class FuncoesDeArquivo
{
	public static string ObterConteudoDoArquivo(string nomeDoArquivo)
	{
		return ObterConteudoDoArquivo(nomeDoArquivo, Encoding.Default);
	}

	public static string ObterConteudoDoArquivo(string nomeDoArquivo, Encoding encoding)
	{
		int num = 0;
		while (true)
		{
			try
			{
				return File.ReadAllText(nomeDoArquivo, encoding);
			}
			catch (IOException ex)
			{
				if (!ArquivoEstaBloqueado(ex))
				{
					throw;
				}
				if (++num > 100)
				{
					throw new Exception($"O arquivo {nomeDoArquivo} está bloqueado por muito tempo. Erro: {ex.Message}", ex);
				}
				Thread.Sleep(250);
			}
		}
	}

	public static FileStream AbrirParaLeitura(string nomeDoArquivo)
	{
		int num = 0;
		while (true)
		{
			try
			{
				return File.OpenRead(nomeDoArquivo);
			}
			catch (IOException ex)
			{
				if (!ArquivoEstaBloqueado(ex))
				{
					throw;
				}
				if (++num > 100)
				{
					throw new Exception($"O arquivo {nomeDoArquivo} está bloqueado por muito tempo. Erro: {ex.Message}", ex);
				}
				Thread.Sleep(250);
			}
		}
	}

	private static bool ArquivoEstaBloqueado(IOException exception)
	{
		int num = Marshal.GetHRForException(exception) & 0xFFFF;
		if (num != 32)
		{
			return num == 33;
		}
		return true;
	}
}

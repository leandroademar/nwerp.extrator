using System.Diagnostics;

//namespace nwErp.Utilidades;

public static class LogDebug
{
	private static Dictionary<string, List<LogRegistro>> registrosDeLog;

	private static readonly object _objectLock = new object();

	private static string diretorioPadrao;

	private static Dictionary<string, List<LogRegistro>> RegistrosDeLog
	{
		get
		{
			if (registrosDeLog == null)
			{
				registrosDeLog = new Dictionary<string, List<LogRegistro>>();
			}
			return registrosDeLog;
		}
		set
		{
		}
	}

	public static bool Ativo { get; set; }

	public static void DefinirDiretorioPadrao(string caminho)
	{
		diretorioPadrao = caminho;
	}

	public static void Adicionar(string chave, string conteudo)
	{
		try
		{
			if (Ativo)
			{
				Adicionar(chave, DateTime.Now, conteudo);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void GravarExcecao(string chave, string nomeArquivo, Exception ex)
	{
		try
		{
			if (!Ativo)
			{
				return;
			}
			int num = 0;
			StackTrace stackTrace = new StackTrace(ex, fNeedFileInfo: true);
			if (stackTrace != null)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				if (frame != null)
				{
					num = frame.GetFileLineNumber();
				}
			}
			string arg = ((ex == null) ? string.Empty : ex.ToString());
			Adicionar(chave, $"Exceção na linha: {num}, {arg}");
			Gravar(nomeArquivo, chave);
		}
		catch (Exception)
		{
		}
	}

	public static void Adicionar(string chave, DateTime data, string conteudo)
	{
		if (Ativo)
		{
			LimparAntigos();
			LogRegistro item = new LogRegistro(data, conteudo);
			if (RegistrosDeLog.Keys.Contains(chave))
			{
				RegistrosDeLog[chave].Add(item);
				return;
			}
			RegistrosDeLog.Add(chave, new List<LogRegistro> { item });
		}
	}

	public static void LimparAntigos()
	{
		if (!Ativo)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (string key in RegistrosDeLog.Keys)
		{
			DateTime value = RegistrosDeLog[key].Max((LogRegistro lg) => lg.DataEHora);
			if (DateTime.Now.Subtract(value).TotalMinutes > 120.0)
			{
				list.Add(key);
			}
		}
		foreach (string item in list)
		{
			Gravar(string.Format("{0}_{1}_{2}", "IMPORTACAOCONGELADA", item, DateTime.Now.ToString("ddMMyyyyHHmmss")), item);
		}
	}

	public static List<LogRegistro> ObterRegistros(string chave)
	{
		if (RegistrosDeLog.Keys.Contains(chave))
		{
			return RegistrosDeLog[chave];
		}
		return null;
	}

	public static List<string> ObterLinhas(string chave)
	{
		List<string> list = new List<string>();
		if (RegistrosDeLog.Keys.Contains(chave))
		{
			foreach (LogRegistro item in RegistrosDeLog[chave])
			{
				list.Add(item.ObterLinha());
			}
		}
		return list;
	}

	public static void Gravar(string nomeArquivo, string chave)
	{
		if (!Ativo)
		{
			return;
		}
		try
		{
			if (string.IsNullOrEmpty(diretorioPadrao))
			{
				diretorioPadrao = $"C:\\Winthor\\Prod\\MOD-020\\SERVIDOR\\LOG\\{DateTime.Now.Year.ToString()}\\{DateTime.Now.Month.ToString()}\\{DateTime.Now.Day.ToString()}\\";
			}
			if (!Directory.Exists(diretorioPadrao))
			{
				Directory.CreateDirectory(diretorioPadrao);
			}
			string caminhoArquivo = Path.Combine(diretorioPadrao, $"{nomeArquivo}.txt");
			List<string> list = ObterLinhas(chave);
			if (list.Count <= 0)
			{
				return;
			}
			lock (_objectLock)
			{
				list.ForEach(delegate(string l)
				{
					File.AppendAllText(caminhoArquivo, $"{l}{Environment.NewLine}");
				});
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			try
			{
				Remover(chave);
			}
			catch (Exception)
			{
			}
		}
	}

	public static void Remover(string chave)
	{
		if (RegistrosDeLog.Keys.Contains(chave))
		{
			RegistrosDeLog.Remove(chave);
		}
	}
}

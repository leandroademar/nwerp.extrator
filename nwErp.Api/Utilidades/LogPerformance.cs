using System.Diagnostics;
using System.Text;

//namespace nwErp.Utilidades;

public static class LogPerformance
{
	private delegate void writeLogAsyncDelegate(string message, string tipoMensagem);

	private static writeLogAsyncDelegate _writeAsyncMethod;

	public static bool _logAtivo;

	private static FileStream logFilestream;

	public static string LogsPath { get; private set; }

	public static void InitializePerformanceLog()
	{
		if (_logAtivo)
		{
			_writeAsyncMethod = OUTAsync;
			LogsPath = "C:\\Winthor\\Prod\\MOD-020\\SERVIDOR\\LOG\\__PERFORMANCE_LOGS";
			if (!Directory.Exists(LogsPath))
			{
				Directory.CreateDirectory(LogsPath);
			}
		}
	}

	public static void write(string message, string tipoMensagem = "INFO")
	{
		if (_logAtivo)
		{
			_writeAsyncMethod.BeginInvoke(message, tipoMensagem, null, null);
		}
	}

	private static void OUTAsync(string message, string tipoMensagem)
	{
		if (!_logAtivo)
		{
			return;
		}
		try
		{
			string s = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{tipoMensagem}] {message}{Environment.NewLine}";
			byte[] bytes = Encoding.Unicode.GetBytes(s);
			string path = Path.Combine(LogsPath, $"{DateTime.Now:yyyy-MM-dd}.log");
			if (!File.Exists(path) || logFilestream == null)
			{
				logFilestream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Read, 4096, useAsync: true);
			}
			logFilestream.Write(bytes, 0, bytes.Length);
			logFilestream.Flush();
		}
		catch (Exception ex)
		{
			Debugger.Log(512, "INTERNAL_WARNING", $"Falha na gravação do log de performance: {ex.Message}");
		}
	}
}

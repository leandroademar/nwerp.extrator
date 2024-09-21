using Newtonsoft.Json;

namespace nwErp.Api.Utilidades;

public static class UtilitarioLogger
  {
    private static string _pathLog;

    public static string PathLog
    {
      get => UtilitarioLogger._pathLog;
      set => UtilitarioLogger._pathLog = value;
    }

    public static void GraveLogErro(string mensagem, params object[] args)
    {
      UtilitarioLogger.GraveLogErro(string.Format(mensagem, args), "Erros");
    }

    public static void GraveLogErro(string mensagem, string nomePasta = "Erros")
    {
      //LogAwsUtil.SalvarLogErro(mensagem);
      string str1 = "\\LogErro";
      if (string.IsNullOrEmpty(UtilitarioLogger._pathLog))
        return;
      if (!Directory.Exists(UtilitarioLogger._pathLog + str1))
        Directory.CreateDirectory(UtilitarioLogger._pathLog + str1);
      if (!string.IsNullOrEmpty(nomePasta))
        str1 = str1 + "\\" + nomePasta;
      string pathLog = UtilitarioLogger._pathLog;
      string str2 = str1;
      DateTime now = DateTime.Now;
      string str3 = now.ToString("ddMMyyyy");
      string path = pathLog + str2 + str3 + ".txt";
      now = DateTime.Now;
      string contents = now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + mensagem + Environment.NewLine;
      File.AppendAllText(path, contents);
    }

    public static void GraveLogInfo(string mensagem, params object[] args)
    {
      UtilitarioLogger.GraveLogInfo(string.Format(mensagem, args), "Infos");
    }

    public static void GraveLogInfo(string mensagem, string nomePasta = "Infos")
    {
      //LogAwsUtil.SalvarLogInformativo(mensagem);
      string str1 = "\\LogInfo";
      if (string.IsNullOrEmpty(UtilitarioLogger._pathLog))
        return;
      if (!Directory.Exists(UtilitarioLogger._pathLog + str1))
        Directory.CreateDirectory(UtilitarioLogger._pathLog + str1);
      if (!string.IsNullOrEmpty(nomePasta))
        str1 = str1 + "\\" + nomePasta;
      string pathLog = UtilitarioLogger._pathLog;
      string str2 = str1;
      DateTime now = DateTime.Now;
      string str3 = now.ToString("ddMMyyyy");
      string path = pathLog + str2 + str3 + ".txt";
      now = DateTime.Now;
      string contents = now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + mensagem + Environment.NewLine;
      File.AppendAllText(path, contents);
    }

    public static void GraveLogSincronizacao(string mensagem, ulong codUsuario, string nomePasta = "Sincronizacao")
    {
      string str = "\\LogSincronizacao";
      if (string.IsNullOrEmpty(UtilitarioLogger._pathLog))
        return;
      if (!Directory.Exists(UtilitarioLogger._pathLog + str))
        Directory.CreateDirectory(UtilitarioLogger._pathLog + str);
      if (!string.IsNullOrEmpty(nomePasta))
        str = str + "\\" + nomePasta;
      File.AppendAllText(UtilitarioLogger._pathLog + str + string.Format("{0:dd.MM.yyyy.HH.mm.ss}-{1}.txt", (object) DateTime.Now, (object) codUsuario), mensagem);
    }

    public static string ObtenhaMessagemParaGravacaoLog(Exception excecao, object objeto)
    {
      return string.Format("ERROR - Data: {0} - Erro: {1}{2} StackTrace: {3} {4} Objeto: {5}", (object) DateTime.Now, (object) excecao.Message, (object) Environment.NewLine, (object) excecao.StackTrace, (object) Environment.NewLine, (object) JsonConvert.SerializeObject(objeto));
    }

    public static string ObtenhaMessagemParaGravacaoLog(string json)
    {
      return string.Format("ERROR - Data: {0} - Json: {1}", (object) DateTime.Now, (object) json);
    }

    public static string ObtenhaMessagemParaGravacaoLog(Exception excecao)
    {
      return string.Format("ERROR - Data: {0} - Json: {1}", (object) DateTime.Now, (object) excecao);
    }

    public static string ObtenhaMessagemParaGravacaoLogError(string nomeMetodo, Exception excecao)
    {
      return string.Format("ERROR - Data: {0} - Metódo: {1} - Mensagem: {2} {3}", (object) DateTime.Now, (object) nomeMetodo, (object) excecao.Message, (object) Environment.NewLine);
    }

    public static string ObtenhaMessagemParaGravacaoLogError(Exception excecao)
    {
      return string.Format("ERROR - Data: {0} -  Mensagem: {1} {2} - {3}", (object) DateTime.Now, (object) excecao.Message, (object) Environment.NewLine, (object) excecao.StackTrace);
    }

    public static string ObtenhaMessagemParaGravacaoLogError(Exception excecao, string json)
    {
      return string.Format("ERROR - Data: {0} -  Mensagem: {1} {2} - {3} - Json: {4}", (object) DateTime.Now, (object) excecao.Message, (object) Environment.NewLine, (object) excecao.StackTrace, (object) json);
    }

    public static string ObtenhaMessagemParaGravacaoLog(string nomeMetodo, string mensagem)
    {
      return string.Format("INFO - data: {0} - Metódo: {1} - Mensagem: {2} {3}", (object) DateTime.Now, (object) nomeMetodo, (object) mensagem, (object) Environment.NewLine);
    }

    public static string ObtenhaMessagemParaGravacaoLogError(string mensagem, object objeto)
    {
      return string.Format("ERROR - Data: {0} -  Mensagem: {1} {2}Objeto: {3}", (object) DateTime.UtcNow, (object) mensagem, (object) Environment.NewLine, (object) JsonConvert.SerializeObject(objeto, Formatting.Indented));
    }

    public static string ObtenhaMensagemLogErro(string mensagem, Exception excecao)
    {
      return string.Format("ERRO - Data: {0} - Mensagem: {1} - Exception: {2} {3} - {4}", (object) DateTime.Now, (object) mensagem, (object) excecao.Message, (object) Environment.NewLine, (object) excecao.StackTrace);
    }
  }
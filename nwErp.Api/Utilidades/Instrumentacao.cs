using Newtonsoft.Json;
using nwErp.Api.Definicoes;

namespace nwErp.Api.Utilidades;

public class Instrumentacao
{
    private const string INFORMATIVO = "Informativo";
    private const string ERRO = "Erro";
    private static string _versaoApp;
    private static string _aplicacao;
    private const string _FimRegistroNovoLog = "--------------------------------------------------------------------------------------------------------------------- ";

    public static void SalvarLogErro(string local, string mensagem, DadosConexao dadosConexao = null)
    {
        try
        {
            Instrumentacao.SalvarLogNoArquivo(local, mensagem, "Erro", dadosConexao);
        }
        catch
        {
        }
    }
    
    public static void SalvarLogNoArquivo(
        string local,
        string mensagem,
        string diretorio,
        DadosConexao dadosConexao = null)
    {
        try
        {
            string str1 = string.Format("Data: {0:dd/MM/yyyy HH:mm:ss:fff zzz} - ", (object) DateTime.Now);
            string str2;
            if (dadosConexao != null)
            {
                dadosConexao.Mensagem = mensagem;
                str2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGS", diretorio, dadosConexao.IdCliente, dadosConexao.Ambiente, local);
            }
            else
                str2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGS", diretorio, local);
            if (!Directory.Exists(str2))
                Directory.CreateDirectory(str2);
            StreamWriter streamWriter = File.AppendText(Path.Combine(str2, string.Format("Erro_{0}.txt", (object) DateTime.Today.ToString("yyyyMMdd"))));
            streamWriter.Write(str1 + mensagem + Environment.NewLine + "--------------------------------------------------------------------------------------------------------------------- " + Environment.NewLine);
            streamWriter.Close();
        }
        catch
        {
        }
        
    }
    
    private static void SalvarLogErroAssync(string mensagem, DadosConexao dadosConexao)
    {
        try
        {
            if (dadosConexao != null)
            {
                dadosConexao.Mensagem = mensagem;
                //LogAwsUtil.SalvarLogErro(Instrumentacao.ObterMensagemDadosConexao(dadosConexao, "Erro"));
            }
            //else
               // LogAwsUtil.SalvarLogErro(Instrumentacao.ObterMessagemPadrao(mensagem, "Erro", (Exception) null));
        }
        catch
        {
        }
    }
    
    public static void SalvarLogInfo(string local, string mensagem, DadosConexao dadosConexao = null)
    {
        try
        {
            Instrumentacao.SalvarLogNoArquivo(local, mensagem, "Informação", dadosConexao);
        }
        catch
        {
        }
    }
    
    private static string ObterMensagemDadosConexao(DadosConexao dadosConexao, string tipo)
    {
        dadosConexao.VersaoApp = Instrumentacao.ObterVersaoApp();
        dadosConexao.NomeApp = Instrumentacao._aplicacao;
        dadosConexao.Tipo = tipo;
        return JsonConvert.SerializeObject((object) dadosConexao, Formatting.Indented);
    }
    
    private static DadosConexao ObterDadosConexaoPadrao(string mesagemErro)
    {
        return new DadosConexao()
        {
            VersaoApp = Instrumentacao.ObterVersaoApp(),
            NomeApp = Instrumentacao._aplicacao,
            Mensagem = mesagemErro
        };
    }
    
    private static string ObterMessagemPadrao(
        string mensagem,
        string tipo,
        Exception ex = null,
        params object[] args)
    {
        DadosConexao dadosConexao = Instrumentacao.ObterDadosConexaoPadrao(mensagem);
        dadosConexao.Excecao = ex;
        dadosConexao.Parametros = args;
        dadosConexao.Tipo = tipo;
        return JsonConvert.SerializeObject((object) dadosConexao, Formatting.Indented);
    }
    
    private static string ObterVersaoApp()
    {
        if (!string.IsNullOrEmpty(Instrumentacao._versaoApp))
            return Instrumentacao._versaoApp;
        string nome = AppDomain.CurrentDomain.FriendlyName;
        Instrumentacao._aplicacao = nome;
        Assembly assembly = ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).FirstOrDefault<Assembly>((Func<Assembly, bool>) (c => c.GetName().Name == nome));
        if (assembly != (Assembly) null)
            Instrumentacao._versaoApp = assembly.GetName().Version.ToString();
        return Instrumentacao._versaoApp;
    }
}
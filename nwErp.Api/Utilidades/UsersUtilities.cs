using nwErp.Api.AppDbContext;

namespace nwErp.Api.Utilidades;

public static class UsersUtilities
{
    public static string ObtenhaUsuarioErp()
    {
        return ConfigurationBinder.GetValue<string>((IConfiguration) UsersUtilities.ObtenhaAppSettings(), "UsuariosSchemas:Erp");
    }
    
    public static string ObtenhaUsuarioNwErp()
    {
        return ConfigurationBinder.GetValue<string>((IConfiguration) UsersUtilities.ObtenhaAppSettings(), "UsuariosSchemas:NwErp");
    }

    public static string ObtenhaUsuarioLogin()
    {
        return ConfigurationBinder.GetValue<string>((IConfiguration) UsersUtilities.ObtenhaAppSettings(), "AcessToken:Login");
    }
    public static string AlterarParametrosUsuarios(this string comando)
    {
        comando = comando.Replace("[#USUARIOERP#]", UsersUtilities.ObtenhaUsuarioErp());
        comando = comando.Replace("[#NWERPDB#]", UsersUtilities.ObtenhaUsuarioNwErp());
        return comando;
    }
    
    private static IConfigurationRoot ObtenhaAppSettings() => AppSettings.Get();
    
    public static string ObtenhaCaminhoDoArquivodeConfiguracao() => "appsettings.json";
    
    public static string AlterarSchemaStringConnection(
        this string connecionstring,
        bool ehUsuarioMaxima)
    {
        connecionstring = connecionstring.Replace("[#SCHEMA#]", UsersUtilities.ObtenhaUsuarioErp());
        if (ehUsuarioMaxima)
            connecionstring = connecionstring.Replace("[#SCHEMA#]", UsersUtilities.ObtenhaUsuarioNwErp());
        return connecionstring;
    }
    
    public static string ObtenhaCaminhoJsonSolucaoPusher()
    {
        return Path.Combine("Conf", "solucaoPusher.json");
    }
}

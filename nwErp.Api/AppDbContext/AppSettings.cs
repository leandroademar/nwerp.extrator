namespace nwErp.Api.AppDbContext;

public class AppSettings
{
    private static IConfigurationRoot _configuration;

    public static IConfigurationRoot Get() => AppSettings._configuration;

    public static void Set(IConfigurationRoot configuration)
    {
        AppSettings._configuration = configuration;
    }
}

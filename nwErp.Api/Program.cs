using Hangfire;
using Hangfire.Console;
using Hangfire.MemoryStorage;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.OpenApi.Models;
using nwErp.Api.AppDbContext;
using nwErp.Api.Configuration;
using nwErp.Api.Jobs;
using nwErp.Api.Persistencia;
using nwErp.Api.Persistencia.Oracle;
using nwErp.Entidades;
using GlobalConfigurationExtensions = Hangfire.MemoryStorage.GlobalConfigurationExtensions;


var builder = WebApplication.CreateBuilder(args);

// Configurar as Connection Strings
EnvironmentVariablesExtensions.AddEnvironmentVariables(JsonConfigurationExtensions.AddJsonFile(FileConfigurationExtensions.SetBasePath(builder.Configuration, Directory.GetCurrentDirectory()), "appsettings.json", optional: false, reloadOnChange: true));

MvcServiceCollectionExtensions.AddControllers(builder.Services);
EndpointMetadataApiExplorerServiceCollectionExtensions.AddEndpointsApiExplorer(builder.Services);
SwaggerGenServiceCollectionExtensions.AddSwaggerGen(builder.Services);
OptionsConfigurationServiceCollectionExtensions.Configure<ConnectionStrings>(builder.Services, builder.Configuration.GetSection("ConnectionStrings"));

// Registrar DbSessions
ServiceCollectionServiceExtensions.AddSingleton<DbSessionTerrazzo>(builder.Services);
ServiceCollectionServiceExtensions.AddSingleton<DbSessionWinthor>(builder.Services);

// Registrar IPersistencia como Singleton
ServiceCollectionServiceExtensions.AddSingleton(builder.Services, provider => 
{
    var configuration = ServiceProviderServiceExtensions.GetRequiredService<IConfiguration>(provider);
    var connectionString = ConfigurationExtensions.GetConnectionString(configuration, "OracleDbConnection");
    return PersistenciaOracle.NovaInstancia(connectionString);
});

// Registrar inMemory
MemoryStorageOptions inMemory = new MemoryStorageOptions()
{
    JobExpirationCheckInterval = TimeSpan.FromMinutes(2.0),
    CountersAggregateInterval = TimeSpan.FromMinutes(1.0),
    FetchNextJobTimeout = TimeSpan.FromMinutes(2.0)
};
        
HangfireServiceCollectionExtensions.AddHangfire(builder.Services, config =>
{
    GlobalConfigurationExtensions.UseMemoryStorage(config, inMemory);
    Hangfire.GlobalConfigurationExtensions.UseSimpleAssemblyNameTypeSerializer(config);
    Hangfire.GlobalConfigurationExtensions.UseRecommendedSerializerSettings(config);
});
        
HangfireServiceCollectionExtensions.AddHangfireServer(builder.Services);

var jobsToRun = builder.Configuration.GetSection("JobsToRun").Get<List<string>>();
foreach (var jobName in jobsToRun)
{
    var jobTypeName = jobName.Trim();
    var jobType = Type.GetType($"nwErp.Api.Jobs.{jobTypeName}");
    if (jobType != null)
    {
        //builder.Services.AddHostedService(jobType);
        var hostedServiceType = typeof(IHostedService);
        builder.Services.AddSingleton(hostedServiceType, jobType);
    }
    else
    {
        Console.WriteLine($"Job {jobTypeName} não encontrado.");
    }
}


var app = builder.Build();
SwaggerBuilderExtensions.UseSwagger(app);
SwaggerUIBuilderExtensions.UseSwaggerUI(app);

HangfireApplicationBuilderExtensions.UseHangfireDashboard(app, "/hangfire", new DashboardOptions
{
    Authorization = new[] { new HangFireDashboard.MyAuthorizationFilter() }
});
        
ControllerEndpointRouteBuilderExtensions.MapControllers(app);
app.Run();

using DotNetEnv;
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
using Supabase; 



var builder = WebApplication.CreateBuilder(args);

// Configurar as Connection Strings
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));

// Registrar DbSessions
builder.Services.AddSingleton<DbSessionTerrazzo>();
builder.Services.AddSingleton<DbSessionWinthor>();
builder.Services.AddSingleton<IHostedService,JobConfiguracaoTesteDB>();

// Registrar IPersistencia como Singleton
builder.Services.AddSingleton<IPersistencia>(provider => 
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("OracleDbConnection");
    return PersistenciaOracle.NovaInstancia(connectionString);
});

// Registrar inMemory
MemoryStorageOptions inMemory = new MemoryStorageOptions()
{
    JobExpirationCheckInterval = TimeSpan.FromMinutes(2.0),
    CountersAggregateInterval = TimeSpan.FromMinutes(1.0),
    FetchNextJobTimeout = TimeSpan.FromMinutes(2.0)
};
        
builder.Services.AddHangfire(config =>
{
    config.UseMemoryStorage(inMemory);
    config.UseSimpleAssemblyNameTypeSerializer();
    config.UseRecommendedSerializerSettings();
});
        
builder.Services.AddHangfireServer();

var jobsToRun = builder.Configuration.GetSection("JobsToRun").Get<List<string>>();
if (jobsToRun != null)
{
    foreach (var jobName in jobsToRun)
    {
        var jobTypeName = jobName.Trim();
        var jobType = Type.GetType($"nwErp.Api.Jobs.{jobTypeName}");
        if (jobType != null)
        {
            var hostedServiceType = typeof(IHostedService);
            builder.Services.AddSingleton(hostedServiceType, jobType);
        }
        else
        {
            Console.WriteLine($"Job {jobTypeName} não encontrado.");
        }
    }
}


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    Authorization = new[] { new HangFireDashboard.MyAuthorizationFilter() }
});
        
app.MapControllers();
app.Run();

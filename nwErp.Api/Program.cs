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
using Supabase; 

var builder = WebApplication.CreateBuilder(args);

// Configurar as Connection Strings
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));

Env.Load();

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


// Configurar o Supabase
var supabaseUrl = Env.GetString("SUPABASE_URL");
var supabaseKey = Env.GetString("SUPABASE_KEY");

var supabaseOptions = new SupabaseOptions
{
    // Defina as opções necessárias aqui
};

var supabaseClient = new Supabase.Client(supabaseUrl, supabaseKey, supabaseOptions);

// Inicialize o cliente Supabase de forma assíncrona
await supabaseClient.InitializeAsync();

// Registrar o Supabase.Client como Singleton
builder.Services.AddSingleton(supabaseClient);

var jobsToRun = Env.GetString("JOB_RUN")?.Split(',');
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

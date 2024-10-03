using Dapper;
using Hangfire;
using Hangfire.Console;
using Hangfire.Server;
using Microsoft.Data.SqlClient;
using nwErp.Api.AppDbContext;
using nwErp.Api.Configuration;
using nwErp.Api.Persistencia;

namespace nwErp.Api.Jobs
{
    public class JobConfiguracaoTesteDB : IHostedService
    {
        private readonly IConfiguration _configuration;
        private readonly IPersistencia _winthorSession;
        private readonly string connectionTerrazzo;
        private readonly string connectionWinthor;

        public JobConfiguracaoTesteDB(IConfiguration configuration, IPersistencia winthorSession)
        {
            _configuration = configuration;
            _winthorSession = winthorSession;
            connectionTerrazzo = _configuration.GetConnectionString("SqlServerConnection");
            connectionWinthor = _configuration.GetConnectionString("OracleDbConnection");
        }

        
        public static void Configure()
        {
            UtilidadeLogConsole.LogConsole("Iniciando processo de criação de estrutura no HangFire", nameof(Configure), UtilidadeLogConsole.TipoMensagem.Atencao);
            CriarTasksJobs();
            UtilidadeLogConsole.LogConsole("Estrutura do HangFire criada com sucesso!", nameof(Configure), UtilidadeLogConsole.TipoMensagem.Sucesso);
        }
        
        public static void CriarTasksJobs()
        {
            RecurringJob.AddOrUpdate<JobConfiguracaoTesteDB>("Teste Conexao DB", x => x.GetTesteConexaoDb(null, CancellationToken.None), Cron.Daily(1), TimeZoneInfo.Local);
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Configure();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        
        public async Task GetTesteConexaoDb(PerformContext context, CancellationToken cancellationToken)
        {
            try
            {
                // Validação da conexão com o SQL Server (Terrazzo)
                context.WriteLine("Testando conexão com SQL Server...");
        
                using (var sqlConnection = new SqlConnection())
                {
                    try
                    {
                        await sqlConnection.OpenAsync(cancellationToken);
                        context.WriteLine("Conexão com SQL Server bem-sucedida.");
                    }
                    catch (Exception ex)
                    {
                        context.WriteLine($"Falha na conexão com SQL Server: {ex.Message}");
                        return; // Se a conexão falhar, abortar a execução
                    }
                }
                
                using (var oracleConnection = new OracleConnection(connectionWinthor))
                {
                    try
                    {
                        await oracleConnection.OpenAsync(cancellationToken);
                        context.WriteLine("Conexão com Oracle bem-sucedida.");
                    }
                    catch (Exception ex)
                    {
                        context.WriteLine($"Falha na conexão com Oracle: {ex.Message}");
                        return; // Se a conexão falhar, abortar a execução
                    }
                }
            }
            catch (Exception ex)
            {
                context.WriteLine($"Erro: {ex.Message}");
                UtilidadeLogConsole.LogConsole($"Falha ao executar teste de conexao: {ex.StackTrace}", nameof(GetTesteConexaoDb), UtilidadeLogConsole.TipoMensagem.Erro);
                cancellationToken.ThrowIfCancellationRequested();
            }
        }
    }
}
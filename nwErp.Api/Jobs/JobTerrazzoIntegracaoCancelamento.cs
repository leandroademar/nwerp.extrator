using nwErp.Api.Persistencia;

namespace nwErp.Api.Jobs;

public class JobTerrazzoIntegracaoCancelamento : IHostedService
{
    private readonly string connectionTerrazzo;
    private readonly string connectionWinthor;
    private readonly IConfiguration _configuration;
    private readonly IPersistencia _persistencia;
    private PCFECHAMENTOMOVCX _pcmovcx;
    private PCPEDCECF _pedidoExistente;
    private List<PCPEDIECF> _pcpediecf = new List<PCPEDIECF>();
    private List<PCPEDCCANCECF> _pcpedccancecf = new List<PCPEDCCANCECF>();
    private List<PCPEDICANCECF> _pcpedicancecf = new List<PCPEDICANCECF>();
    private List<PCPRESTECF> _pcprestecf = new List<PCPRESTECF>();
    private List<PCORIGEMPRECOECF> _origempreco = new List<PCORIGEMPRECOECF>();
    private List<PCDOCELETRONICOECF> _documento = new List<PCDOCELETRONICOECF>();
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Configure();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
    
    public JobTerrazzoIntegracaoCancelamento(IConfiguration configuration, IPersistencia persistencia)
    {
        _configuration = configuration;
        _persistencia = persistencia;
        connectionTerrazzo = _configuration.GetConnectionString("terrazzo");
        connectionWinthor = _configuration.GetConnectionString("winthor");
    }
    
    public static void Configure()
    {
        //UtilidadeLogConsole.LogConsole("Iniciando processo de criação de estrutura no HangFire", nameof(Configure), UtilidadeLogConsole.TipoMensagem.Atencao);
        //CriarTasksJobs();
        //UtilidadeLogConsole.LogConsole("Estrutura do HangFire criada com sucesso!", nameof(Configure), UtilidadeLogConsole.TipoMensagem.Sucesso);
    }
    
    public static void CriarTasksJobs()
    {
        //RecurringJob.AddOrUpdate<JobTerrazzoIntegracaoCancelamento>("Teste Conexao DB", x => x.GetTesteConexaoDb(null, CancellationToken.None), Cron.Daily(1), TimeZoneInfo.Local);
    }
    
   
 
}
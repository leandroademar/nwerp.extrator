using nwErp.Api.Persistencia;

namespace nwErp.Api.Jobs.Kinitos;

public class JobPedidoTranferenciaAutomatico : IHostedService
{
    private readonly IConfiguration _configuration;
    private readonly IPersistencia _persistencia;
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Configure();
        return Task.CompletedTask;

    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public static void Configure()
    {
        
    }

    
}
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using nwErp.Api.Jobs;

namespace nwErp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabaseTestController : Controller
    {
        private readonly ILogger<DatabaseTestController> _logger;
        private readonly JobConfiguracaoTesteDB _jobConfiguracaoTesteDB;

        public DatabaseTestController(ILogger<DatabaseTestController> logger, JobConfiguracaoTesteDB jobConfiguracaoTesteDB)
        {
            _logger = logger;
            _jobConfiguracaoTesteDB = jobConfiguracaoTesteDB;
        }

        [HttpGet("TesteDb")]
        public IActionResult TesteDb()
        {
            // Executar o método de teste de conexões do job
            BackgroundJob.Enqueue(() => _jobConfiguracaoTesteDB.GetTesteConexaoDb(null,CancellationToken.None));

            return Ok("Job de teste de conexão enfileirado.");
        }
    }
}
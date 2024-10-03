using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace nwErp.Api.Controllers;

[Route("/api/[controller]/[action]")]
[ApiExplorerSettings(IgnoreApi = true)]
[AllowAnonymous]
public class MonitorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
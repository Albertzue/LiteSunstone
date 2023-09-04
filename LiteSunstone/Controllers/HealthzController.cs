using Microsoft.AspNetCore.Mvc;

namespace LiteSunstone.Api.Controllers
{
    [ApiController]
    public class HealthController : Controller
    {
        [HttpGet("/healthz")]
        public IActionResult Health()
        {
            return Ok("working");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace LiteSunstone.Api.Controllers
{
    [ApiController]
    public class HealthController : Controller
    {
        [HttpGet("/health")]
        public IActionResult Health()
        {
            return Ok();
        }
    }
}

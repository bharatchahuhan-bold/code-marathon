using CodeMarathon.ResumeBuilder.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CodeMarathon.ResumeBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        public HealthController()
        {
        }

        [HttpGet(ApiRoutes.HealthStatusEndpoint)]
        [Authorize]
        public async Task<IActionResult> GetHealthStatus()
        {
            return Ok($"App is up at {DateTime.UtcNow}  UTC.");
        }
    }
}

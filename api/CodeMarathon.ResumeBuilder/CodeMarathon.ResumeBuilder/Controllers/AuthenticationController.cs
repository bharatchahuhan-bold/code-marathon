using CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.Authentication;
using CodeMarathon.ResumeBuilder.Common;
using CodeMarathon.ResumeBuilder.DTOs.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodeMarathon.ResumeBuilder.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost(ApiRoutes.AuthenticationEndpoint)]
        public async Task<IActionResult> SignInWithLinkedIn([FromBody] AuthenticationRequest authRequest)
        {
            var response = await _authenticationService.SignInWithLinkedIn(authRequest);
            return Ok(response);
        }
    }
}

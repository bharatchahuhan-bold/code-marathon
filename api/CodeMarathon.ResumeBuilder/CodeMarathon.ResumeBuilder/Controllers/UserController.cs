using CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.User;
using CodeMarathon.ResumeBuilder.DTOs.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodeMarathon.ResumeBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> GetUserDetails([FromBody] AuthenticationRequest authCode)
        {
            var response = await _userService.GetUserDetailsByLinkedInToken(authCode.AuthCode);
            return Ok(response);
        }
    }
}

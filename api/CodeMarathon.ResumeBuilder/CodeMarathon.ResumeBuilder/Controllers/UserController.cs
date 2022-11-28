using CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.User;
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

        [HttpGet]
        public async Task<IActionResult> GetUserDetails()
        {
            var token = Request.Headers["Authorization"].ToString();
            var response = await _userService.GetUserDetailsByLinkedInToken(token);
            return Ok(response);
        }
    }
}

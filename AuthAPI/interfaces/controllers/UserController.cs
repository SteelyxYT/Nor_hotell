using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.interfaces.controllers
{
    [ApiController]
    [Route("api/v1/users")]
    public class UserController: ControllerBase
    {
        [HttpPost("register")]
        public IActionResult register()
        {
            return Ok("register");
        }

        [HttpGet("{id}")]
        public IActionResult getProfile(int id)
        {
            return Ok("getProfile");
        }

        [HttpGet]
        public IActionResult getProfiles()
        {
            return Ok("getProfiles");
        }
    }
}

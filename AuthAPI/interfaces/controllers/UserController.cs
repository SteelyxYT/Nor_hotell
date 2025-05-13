using AuthAPI.application.use_cases;
using AuthAPI.domain.entities;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.interfaces.controllers
{
    [ApiController]
    [Route("api/v1/users")]
    public class UserController: ControllerBase
    {
        private readonly RegisterUser registerUserUseCase;
        private readonly GetUserProfile getUserProfileUseCase;

        public UserController(RegisterUser registerUserUseCase, GetUserProfile getUserProfileUseCase)
        {
            this.registerUserUseCase = registerUserUseCase;
            this.getUserProfileUseCase = getUserProfileUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> register([FromBody] Register RegistrationForm)
        {
            try
            {
                User? user = await registerUserUseCase.execute(RegistrationForm.username, RegistrationForm.password, RegistrationForm.email);
                return StatusCode(201, user);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }


        [HttpGet("profile/{username}")]
        public async Task<IActionResult> getProfile(string username)
        {
            try
            {
                User? user = await getUserProfileUseCase.execute(username);
                return Ok(user);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }
    }
}

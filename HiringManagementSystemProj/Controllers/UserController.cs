using HiringManagementSystemProj.DTOs;
using HiringManagementSystemProj.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HiringManagementSystemProj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserDto userDto)
        {
            try
            {
                var user = await _userService.RegisterUserAsync(userDto);
                return Ok(new { message = "User created successfully", user });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }

}

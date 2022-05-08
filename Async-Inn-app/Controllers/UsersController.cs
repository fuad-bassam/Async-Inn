using Async_Inn_app.models;
using Async_Inn_app.models.DTO;
using Async_Inn_app.models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _user;


        public UsersController(IUserService userService)
        {
            _user = userService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterUserDto data)
        {

            try {
                UserDto userDto= await _user.Register(data, this.ModelState);
            if (ModelState.IsValid)
            {
                return Ok(userDto);

            }
            return BadRequest(new ValidationProblemDetails(ModelState));

            }
            catch (Exception e)
            { return BadRequest(e.Message); }
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserDto>> Login(RegisterUserDto user)
        {
            UserDto userDto = await _user.Authenticate(user.Username, user.Password);
                if (userDto != null)
                {
                    return Ok(userDto);

                }
                return BadRequest("user and password not matching");

        
        }

    }
}

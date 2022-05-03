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
        public Task<ApplicationUser> Register(RegisterUser data)
        {
            throw new NotImplementedException();
        }

    }
}

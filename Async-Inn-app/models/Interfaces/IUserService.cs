using Async_Inn_app.models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
    public interface IUserService
    {

        //ApplicationUser
        public Task<UserDto> Register(RegisterUserDto data, ModelStateDictionary modelstate);


        ////UserDto
        public Task<UserDto> Authenticate(string username, string password);
        
    }
}

using Async_Inn_app.models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
    public class IdentityUserService : IUserService
    {
        public Task<UserDto> Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        //public async Task<ApplicationUser> Register(RegisterUser data)
        //{
        //    // throw new NotImplementedException();
        //    var user = new ApplicationUser
        //    {
        //        UserName = data.Username,
        //        Email = data.Email,
        //        PhoneNumber = data.PhoneNumber
        //    };

        //    var result = await userManager.CreateAsync(user, data.Password);

        //    if (result.Succeeded)
        //    {
        //        return user;
        //    }
        //    return null;
        //}

        public Task<UserDto> Register(RegisterUser data, ModelStateDictionary modelState)
        {
            throw new NotImplementedException();
        }
    }
}

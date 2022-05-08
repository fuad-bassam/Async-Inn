using Async_Inn_app.models.DTO;
using Async_Inn_app.models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Services
{
    public class IdentityUserService : IUserService
    {
        private UserManager<ApplicationUser> _userManager;

        public IdentityUserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }


        public async Task<UserDto> Register(RegisterUserDto registerDto, ModelStateDictionary modelstate)
        {
            var user = new ApplicationUser
            {
                UserName = registerDto.Username,
                Email = registerDto.Email,
                Gender = registerDto.PhoneNumber,
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (result.Succeeded)
            {

                var userDto = new UserDto
                {
                    Username = user.UserName,
                    Id = user.Id,
                
                };
                return userDto;
            }
            foreach (var error in result.Errors)
            {
             
                var errorKey =
                    error.Code.Contains("Password") ? "Password Issue" :
                    error.Code.Contains("Email") ? "Email Issue" :
                    error.Code.Contains("UserName") ? nameof(registerDto.Username) :
                    "";

                modelstate.AddModelError(errorKey, error.Description);
            }
            return null;


        }
        public async Task<UserDto> Authenticate(string username, string password)
        { 
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                if (await _userManager.CheckPasswordAsync(user, password))
                {
                    var userDto = new UserDto
                    {
                        Username = user.UserName,
                        Id = user.Id,     
                    };
                    return userDto;
                }}

            //return  (user and password not matching)
            return null;
        }
    }
    
}

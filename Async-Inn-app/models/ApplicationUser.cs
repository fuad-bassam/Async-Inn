using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class ApplicationUser : IdentityUser
    {
        public string Gender { get; set; }
    }
}

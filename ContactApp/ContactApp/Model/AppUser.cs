using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApp.Model
{
    public class AppUser:IdentityUser
    {
        public Contact Contact { get; set; } 
    }
}

﻿using Microsoft.AspNetCore.Identity;

namespace DynamicBox.IdentityServer.Models
{

    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
        public string BusinessCode { get; set; }
    }
}

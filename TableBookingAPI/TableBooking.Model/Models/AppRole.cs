﻿using Microsoft.AspNetCore.Identity;

namespace TableBooking.Model.Models
{
    public class AppRole : IdentityRole
    {
        public AppRole(string roleName)
        {
            Name = roleName;
        }
    }
}
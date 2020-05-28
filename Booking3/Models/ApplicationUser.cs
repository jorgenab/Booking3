﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking3.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Navigation property
        public virtual ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}

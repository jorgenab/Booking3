﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Booking3.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public DateTime TimeOfRegistration { get; set; }

        // Navigation property
        public virtual ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}

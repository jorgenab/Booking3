using System;
using System.Collections.Generic;
using System.Text;
using Booking3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Booking3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<GymClass> GymClasses { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUserGymClass>()
                .HasKey(t => new { t.ApplicationsUserID, t.GymClassId });
        }
    }
}

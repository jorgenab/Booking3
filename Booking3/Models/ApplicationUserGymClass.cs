using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking3.Models
{
    public class ApplicationUserGymClass
    {
        // Foreign keys
        public int ApplicationsUserID { get; set; }
        public int GymClassId { get; set; }

        // Navigation properties
        public ApplicationUser ApplicationUser { get; set; }
        public GymClass GymClass { get; set; }
    }
}

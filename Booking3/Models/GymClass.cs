using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking3.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public String Decsription { get; set; }

        // Navigation property
        public virtual ICollection<ApplicationUserGymClass> AttendingMembers { get; set; }
    }
}

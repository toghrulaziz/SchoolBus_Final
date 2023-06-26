using SchoolBusFinalTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusFinalTask.Models.Concretes
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? CarId { get; set; }
        public bool HasLicence { get; set; }
        public string Address { get; set; } = null!;


        public virtual Car? Car { get; set; }
        public virtual ICollection<Ride>? Rides { get; set; }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}

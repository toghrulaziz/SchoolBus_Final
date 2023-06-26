using SchoolBusFinalTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusFinalTask.Models.Concretes
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int ParentId { get; set; }
        public int? RideId { get; set; }
        public int ClassId { get; set; }
        public string HomeAddress { get; set; } = null!;
        public string? OtherAddress { get; set; }


        public virtual Parent? Parent { get; set; }
        public virtual Ride? Ride { get; set; }
        public virtual Class? Class { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }
    }
}

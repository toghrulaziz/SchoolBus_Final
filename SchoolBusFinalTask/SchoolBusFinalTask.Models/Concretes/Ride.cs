using SchoolBusFinalTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusFinalTask.Models.Concretes
{
    public class Ride : BaseEntity
    {
        public int DriverId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }


        public virtual Driver? Driver { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
    }
}

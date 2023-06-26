using SchoolBusFinalTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusFinalTask.Models.Concretes
{
    public class Parent : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;


        public virtual ICollection<Student>? Students { get; set; }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

using SchoolBusFinalTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusFinalTask.Models.Concretes
{
    public class Class : BaseEntity
    {
        public string Name { get; set; } = null!;


        public virtual ICollection<Student>? Students { get; set; }


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

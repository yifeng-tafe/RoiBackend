using System;
using System.Collections.Generic;

#nullable disable

namespace RoiBackend.Models
{
    public partial class Department
    {
        public Department()
        {
            People = new HashSet<Person>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}

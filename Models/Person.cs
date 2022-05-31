using System;
using System.Collections.Generic;

#nullable disable

namespace RoiBackend.Models
{
    public partial class Person
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public byte? DepartmentId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        public virtual Department Department { get; set; }
    }
}

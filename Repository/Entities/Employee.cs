using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Employee: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}

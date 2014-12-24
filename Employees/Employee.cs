using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    public class Employee
    {
        public int employeeid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birth { get; set; }
        public string telephoneNumber { get; set; }
        public Function function { get; set; }
        public DateTime createdAt { get; set; }

        public string fullName {
            get  { return this.firstName + " " + this.lastName; }
        }
    }   
}

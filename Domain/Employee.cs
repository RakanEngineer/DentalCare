using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Domain
{
    abstract class Employee : Person
    {
        public Employee(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email, string id, ushort salary)
           : base(firstName, lastName, socialSecurityNumber, phoneNumber, email)
        {
            Id = id;
            Salary = salary;
        }

        public string Id { get; }
        public ushort Salary { get; }
    }
}
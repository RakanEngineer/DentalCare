using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Domain
{
    abstract class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public string PhoneNumber { get; }
        public string Email { get; }

        public Person(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

}
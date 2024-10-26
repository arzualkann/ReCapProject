using Core.Entities;
using Core.Utilities.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:User
    {
        public string PhoneNumber { get; set; }
        public string? CompanyName { get; set; }
        public List<Rental> Rentals { get; set; }

        public Customer(int id, string username, string firstName, string lastName, DateTime dateOfBirth, string nationalIdentity, string email, byte[] passwordHash, byte[] passwordSalt,string companyName, string phoneNumber)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            NationalIdentity = nationalIdentity;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            CompanyName = companyName;
            PhoneNumber = phoneNumber;
        }


        public Customer()
        {
            
        }
    }
}

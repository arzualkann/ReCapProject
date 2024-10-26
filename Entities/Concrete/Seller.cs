using Core.Utilities.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Seller : User
    {
        public string CompanyName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime RegistrationDate { get; set; } 
        public virtual ICollection<Car> Cars { get; set; } 

        public Seller(int id, string username, string firstName, string lastName, DateTime dateOfBirth, string nationalIdentity, string email, byte[] passwordHash, byte[] passwordSalt, string companyName, string taxNumber)
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
            Cars = new List<Car>();
        }

        public Seller()
        {
            Cars = new List<Car>();
        }
    }

}

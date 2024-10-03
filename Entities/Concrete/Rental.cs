using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental:BaseEntity<int>
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Car Car { get; set; }
        public Customer Customer { get; set; }

        public Rental(int id, int carId, int customerId, DateTime rentalDate, DateTime? returnDate)
        {
            Id = id;
            CarId = carId;
            CustomerId = customerId;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
        }

        public Rental()
        {
            
        }
    }
}

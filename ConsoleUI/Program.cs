using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CustomerTest();

RentalTest();

static void CustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    customerManager.Add(new Customer { CustomerId = 1, UserId = 1, CompanyName = "tobeto" });
    var result = customerManager.GetAll();
    if (result.Success)
    {
        foreach (var customer in result.Data)
        {
            Console.WriteLine(customer.CustomerId);
        }

    }
}

static void RentalTest()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());
    //rentalManager.Add(new Rental {RentalId=1,CarId=1,CustomerId=5,RentalDate= new DateTime(2024, 12, 1),ReturnDate=new DateTime(2024,12,8) });
    var result2 = rentalManager.GetAll();
    if (result2.Success)
    {
        foreach (var rental in result2.Data)
        {
            Console.WriteLine(rental.RentalDate + "//" + rental.ReturnDate);
        }
    }
}
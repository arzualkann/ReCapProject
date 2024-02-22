using Business.Concretes;
using DataAccess.Concretes.EntityFrameWork;
using DataAccess.Concretes.InMemory;
using Entities;
using Entities.Conceretes;
using Entities.DTOs;

////CarTest();
//CarTest();
//CarManager carManager = new CarManager(new EfCarDal());


//List<CarDetailDto> result = (List<CarDetailDto>)carManager.GetCarDetails();

//foreach (var car in result)
//{
//    Console.WriteLine(car.CarName + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);
//}

//static void CarTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    carManager.Add(new Car { ColorId = 1,CarName="Renault", BrandId = 1, ModelYear = 2014, DailyPrice = 214.3m, Description = "Sedan, 5 kişilik, manuel vites" });
//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine("{0}/{1}/{2}", car.Id, car.DailyPrice, car.ModelYear);
//    }
//}

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarTest();

//BrandTest();

//ColorManager colorManager=new ColorManager(new EfColorDal());
//colorManager.Add(new Color { ColorId = 13, Name = "mor" });

//foreach (var color in colorManager.GetAll())
//{
//    Console.WriteLine(color.ColorName);
//}


//static void BrandTest()
//{
//    BrandManager brandManager = new BrandManager(new EfBrandDal());
//    var brandById = brandManager.GetById(1);
//    Console.WriteLine(brandById.BrandName);
//}

//static void CarTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    carManager.Add(new Car { Id = 11, BrandId = 2, ColorId = 1, ModelYear = 1998, DailyPrice = 5, Description = "deneme" });
//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine(car.Description);
//    }
//}

//deneme
//-----------------------------------------------
//Dto-join test
//CarManager carManager=new CarManager(new EfCarDal());
//foreach (var car in carManager.GetCarDetails())
//{
//    Console.WriteLine(car.BrandName+"/"+car.DailyPrice+"/"+car.ColorName);
//}
//deneme
//-------------------------------------------------------------------------------////-------------------------//
CarManager carManager=new CarManager(new EfCarDal());
var result = carManager.GetCarDetails();
if (result.Success==true)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.BrandName+"/"+car.DailyPrice);
    }
}
else
{
    Console.WriteLine(result.Message);
}
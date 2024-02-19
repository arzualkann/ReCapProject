using DataAccess.Concretes.InMemory;
using Entities;

ImCarDal carDal = new ImCarDal();

// Tüm arabaları listele
Console.WriteLine("Tüm arabalar:");
List<Car> cars = carDal.GetAll();
foreach (var car in cars)
{
    Console.WriteLine($"Id: {car.Id}, BrandId: {car.BrandId},ModelYear: {car.ModelYear}, DailyPrice: {car.DailyPrice}, Description: {car.Description}");
}

// Id'si 2 olan araba
Console.WriteLine("\nId'si 2 olan araba:");
Car carById = carDal.GetById(2);
Console.WriteLine($"Id: {carById.Id}, BrandId: {carById.BrandId}, ModelYear: {carById.ModelYear}, DailyPrice: {carById.DailyPrice}, Description: {carById.Description}");

// Yeni araba ekle
Console.WriteLine("\nYeni araba ekleniyor...");
Car newCar = new Car { Id = 4, BrandId = 1,ModelYear = 2023, DailyPrice = 300, Description = "Volkswagen Golf" };
carDal.Add(newCar);
Console.WriteLine("Yeni araba eklendi. Güncel araba listesi:");
foreach (var car in carDal.GetAll())
{
    Console.WriteLine($"Id: {car.Id}, BrandId: {car.BrandId}, ModelYear: {car.ModelYear}, DailyPrice: {car.DailyPrice}, Description: {car.Description}");
}

// Id'si 1 olan arabanın güncellenmiş hali
Console.WriteLine("\nId'si 1 olan arabanın güncellenmiş hali:");
Car updatedCar = new Car { Id = 1, BrandId = 1,ModelYear = 2022, DailyPrice = 270, Description = "BMW X5 M" };
carDal.Update(updatedCar);
Console.WriteLine($"Id: {updatedCar.Id}, BrandId: {updatedCar.BrandId}, ModelYear: {updatedCar.ModelYear}, DailyPrice: {updatedCar.DailyPrice}, Description: {updatedCar.Description}");

// Id'si 3 olan araba siliniyor
Console.WriteLine("\nId'si 3 olan araba siliniyor...");
carDal.Delete(3);
Console.WriteLine("Araba silindi. Güncel araba listesi:");
foreach (var car in carDal.GetAll())
{
    Console.WriteLine($"Id: {car.Id}, BrandId: {car.BrandId}, ModelYear: {car.ModelYear}, DailyPrice: {car.DailyPrice}, Description: {car.Description}");
}
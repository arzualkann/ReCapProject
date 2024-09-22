using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car { Id = 1,BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=1250,Description="dizel,otomatik"},
                new Car { Id = 2,BrandId=2,ColorId=1,ModelYear=2016,DailyPrice=1700,Description="dizel,otomatik"},
                new Car { Id = 3,BrandId=3,ColorId=2,ModelYear=2015,DailyPrice=2000,Description="benzinli,otomatik"},
                new Car { Id = 4,BrandId=4,ColorId=2,ModelYear=2017,DailyPrice=1500,Description="benzinli,otomatik"},
                new Car { Id = 5,BrandId=5,ColorId=3,ModelYear=2018,DailyPrice=1300,Description="dizel,manul"},
                new Car { Id = 6,BrandId=6,ColorId=4,ModelYear=2018,DailyPrice=1400,Description="dizel,manuel"},
                new Car { Id = 7,BrandId=7,ColorId=5,ModelYear=2019,DailyPrice=1250,Description="dizel,manuel"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(p=>p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p=>p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(p=> p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

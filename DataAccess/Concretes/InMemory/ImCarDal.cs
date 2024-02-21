using DataAccess.Abstracts;
using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory;

public class ImCarDal : ICarDal
{
    List<Car> _cars;
    public ImCarDal()
    {
        _cars = new List<Car>
        {
            new Car { Id = 1, BrandId = 1,ModelYear = 2022, DailyPrice = 250, Description = "BMW X5" },
            new Car { Id = 2, BrandId = 2,ModelYear = 2021, DailyPrice = 200, Description = "Audi A3" },
            new Car { Id = 3, BrandId = 3,ModelYear = 2020, DailyPrice = 150, Description = "Mercedes C180" }
        };
    }
    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car GetById(int id)
    {
        return _cars.SingleOrDefault(c => c.Id == id);
    }
    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
        if (carToUpdate != null)
        {
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }

    public void Delete(int id)
    {
        Car carToDelete = _cars.SingleOrDefault(c => c.Id == id);
        if (carToDelete != null)
        {
            _cars.Remove(carToDelete);
        }
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Delete(Car entity)
    {
        throw new NotImplementedException();
    }
}

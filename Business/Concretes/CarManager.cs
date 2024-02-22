using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;
public class CarManager : ICarService
{
    private ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public void Add(Car car)
    {
        if (car.DailyPrice > 0)
        {
            _carDal.Add(car);
        }
        else
        {
            Console.WriteLine("Günlük kiralama bedeli 0'dan büyük olmalı");
        }
    }

    public void Delete(int id)
    {
        _carDal.Get(b => b.Id == id);
    }

    public void Update(Car car)
    {
        _carDal.Update(car);
    }

    public List<Car> GetAll()
    {

        return _carDal.GetAll();
    }

    public Car GetById(int id)
    {

        return _carDal.Get(b => b.Id == id);
    }

    public IEnumerable<object> GetCarDetails()
    {
        throw new NotImplementedException();
    }
}


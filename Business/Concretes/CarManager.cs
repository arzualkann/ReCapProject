using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CarManager
{
    private ICarDal _carDal;
    
    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public void Add(Car car)
    {
        _carDal.Add(car);
    }

    public void Delete(int id)
    {
        _carDal.Delete(id);
    }
    public void Update(Car car)
    {
        _carDal.Update(car);
    }
    public List<Car> GetAll()
    {
        // İş mantığı eklemeden önce gerekiyorsa validasyonlar yapılabilir
        return _carDal.GetAll();
    }

    public Car GetById(int id)
    {
        // İş mantığı eklemeden önce gerekiyorsa validasyonlar yapılabilir
        return _carDal.GetById(id);
    }

}

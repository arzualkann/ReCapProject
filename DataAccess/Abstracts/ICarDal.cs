using Entities.Conceretes;
using Entities.DTOs;
using ReCapProject.DataAccess.Concretes.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface ICarDal:IEntityRepository<Car>
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (var context = new MyDbContext())
        {
            var result = from car in context.Cars
                         join brand in context.Brands on car.BrandId equals brand.Id
                         join color in context.Colors on car.ColorId equals color.Id
                         select new CarDetailDto
                         {
                             CarName = car.CarName,
                             BrandName = brand.BrandName,
                             ColorName = color.ColorName,
                             DailyPrice = car.DailyPrice
                         };
            return result.ToList();
        }
    }


}

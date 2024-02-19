using Business.Concretes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface ICarService
{
    void Add(Car car);
    void Update(Car car);
    void Delete(int id);
    void GetAll(Car car);
    void GetById(int id);


}

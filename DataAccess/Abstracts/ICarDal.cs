﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface ICarDal
{
    List<Car> GetAll();
    Car GetById(int id);
    void Add(Car car);
    void Update(Car car);
    void Delete(int id);
}

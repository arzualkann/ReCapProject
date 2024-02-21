using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    void Add(Brand brand);
    void Delete(int id);
    void Update(Brand brand);
    List<Brand> GetAll();
    Brand GetById(int id);
}

using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.Name.Length >= 2)
            {
                _brandDal.Add(brand);
            }
            Console.WriteLine("Marka ismi 2'den kısa olmamalı.");
            
        }

        public void Delete(int id)
        {
            _brandDal.Delete(new Brand { Id = id });
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public List<Brand> GetAll()
        {

            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {

            return _brandDal.Get(b => b.Id == id);
        }

    }
}

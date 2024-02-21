using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class ColorManager : IColorService
{
    private IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public void Add(Color color)
    {

        _colorDal.Add(color);
    }

    public void Delete(int id)
    {

        _colorDal.Delete(new Color { Id = id });
    }

    public List<Color> GetAll()
    {

        return _colorDal.GetAll();
    }

    public Color GetById(int id)
    {

        return _colorDal.Get(c => c.Id == id);
    }

    public void Update(Color color)
    {

        _colorDal.Update(color);
    }
}

using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IColorService
{
    void Add(Color color);
    void Delete(int id);
    void Update(Color color);
    List<Color> GetAll();
    Color GetById(int id);
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Model:BaseEntity<int>
    {
        public int BrandId { get; set; }
        public string ModelName { get; set; }

        public virtual Brand? Brand { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public Model()
        {
            Cars = new HashSet<Car>();
        }

        public Model(int id, int brandId, string modelName)
        {
            Id = id;
            BrandId = brandId;
            ModelName = modelName;
        }
    }
}

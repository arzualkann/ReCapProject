using Core.Entities;

namespace Entities.Concrete
{
    public class Brand:BaseEntity<int>
    {
        public string BrandName { get; set; }
        public List<Car> Cars { get; set; }

        public Brand(int id, string brandName)
        {
            Id= id;
            BrandName = brandName;
            Cars =new List<Car>();
        }

        public Brand()
        {
            Cars= new List<Car>();
        }
    }
}

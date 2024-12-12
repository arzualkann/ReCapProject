using Core.Entities;

namespace Entities.Concrete
{
    public class Brand:BaseEntity<int>
    {
        public string BrandName { get; set; }
        public ICollection<Model> Models { get; set; }

        public Brand()
        {
            Models = new HashSet<Model>();
        }

        public Brand(int id, string brandName) : this()
        {
            Id = id;
            BrandName = brandName;
        }
    }
}

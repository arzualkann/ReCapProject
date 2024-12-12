using Core.Entities;

namespace Entities.Concrete
{
    public class Color:BaseEntity<int>
    {
        public string ColorName { get; set; }
        public ICollection<Car> Cars { get; set; }

        public Color()
        {
            Cars = new HashSet<Car>();
        }

        public Color(int id,string colorName)
        {
            Id = id;
            ColorName = colorName;
        }
    }
}

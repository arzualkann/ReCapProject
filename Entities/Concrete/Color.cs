using Core.Entities;

namespace Entities.Concrete
{
    public class Color:BaseEntity<int>
    {
        public string ColorName { get; set; }
        public List<Car> Cars { get; set; }

        public Color(int id, string colorName)
        {
            Id = id;
            ColorName = colorName;
            Cars = new List<Car>(); // Koleksiyonu başlat
        }

        public Color()
        {
            Cars=new List<Car>();
        }
    }
}

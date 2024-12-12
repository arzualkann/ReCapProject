using Core.Entities;

namespace Entities.Concrete
{
    public class Car:BaseEntity<int>
    {
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public int State { get; set; }
        public decimal DailyPrice {  get; set; }
        public string Description { get; set; }
        public int Findeks { get; set; }


        public Model Model { get; set; }
        public Brand Brand { get; set; }
        public Color Color { get; set; }

        public virtual ICollection<CarImage> CarImages { get; set; }

        public Car(int id,int brandId, int colorId, int modelId, int modelYear, string plate, int state, decimal dailyPrice, string description, int findeks)
        {
            Id = id;
            BrandId = brandId;
            ColorId = colorId;
            ModelId = modelId;
            ModelYear = modelYear;
            Plate = plate;
            State = state;
            DailyPrice = dailyPrice;
            Description = description;
            Findeks = findeks;
        }
    }
}

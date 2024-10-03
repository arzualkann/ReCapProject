using Core.Entities;

namespace Entities.Concrete
{
    public class Car:BaseEntity<int>
    {
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice {  get; set; }
        public string Description { get; set; }
        public Brand Brand { get; set; }
        public Color Color { get; set; }
        public List<CarImage> CarImages { get; set; }
        public List<Rental> Rentals { get; set; }
        public Car(int id, int brandId, int colorId, int modelYear, decimal dailyPrice, string description)
        {
            Id = id;
            BrandId = brandId;
            ColorId = colorId;
            ModelYear = modelYear;
            DailyPrice = dailyPrice;
            Description = description;
            Rentals = new List<Rental>();
            CarImages = new List<CarImage>();
        }
        public Car()
        {
            CarImages = new List<CarImage>();
            Rentals = new List<Rental>();
        }
    }
}

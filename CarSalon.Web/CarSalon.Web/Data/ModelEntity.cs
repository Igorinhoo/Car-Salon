using System.Numerics;

namespace CarSalon.Web.Data
{
    public enum Fuel
    {
        Gas,
        Diesel,
        Petrol,
        Electric,
        Hybrid
    }
    public enum CarType
    {
        Passenger,
        Truck,
        Bus,
        Racing
    }
    public class ModelEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MadeIn { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public Fuel Fuel { get; set; }
        public CarType CarType { get; set; } = CarType.Passenger;
        public string ImgUrl { get; set; }
        public long ViewNumber { get; set; } 
        public BrandEntity Brand { get; set; }
        public int BrandForeignKey { get; set; }

        public ICollection<Model_EquipmentEntity> ModelEquipments { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ModelEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            ViewNumber = 0;
        }
    }
}

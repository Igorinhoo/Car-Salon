namespace CarSalon.Web.Data
{
    public enum Fuel
    {
        Gas,
        Diesel,
        Petrol,
        Electric
    }

    public enum CarType
    {
        Truck,
        Bus,
        Passenger,
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

        public BrandEntity Brand { get; set; }
        public int BrandForeignKey { get; set; }

        public EquipmentEntity Equipment{ get; set; }
        public int EquipmentForeignKey { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ModelEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

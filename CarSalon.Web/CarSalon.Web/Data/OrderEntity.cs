namespace CarSalon.Web.Data
{
 
    public class OrderEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public CarType CarType { get; set; } = CarType.Passenger;
        public double Price { get; set; }
        public Boolean IsNew { get; set; } = true;
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }


        public DateTime CreatedAt { get; set; }
 
        public OrderEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}

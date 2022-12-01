using CarSalon.Web.Data;


namespace CarSalon.Web.Models.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public CarType CarType { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }


        public OrderDto(OrderEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Surname = entity.Surname;
            CarType = entity.CarType;
            Price = entity.Price;
            IsNew = entity.IsNew;
            PhoneNumber = entity.PhoneNumber;
            if(entity.Email != null) { 
                Email = entity.Email;
            }

        }


        
    }
}

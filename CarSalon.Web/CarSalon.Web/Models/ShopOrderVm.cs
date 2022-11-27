using CarSalon.Web.Data;
using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models.DTOs;
using System.Runtime.InteropServices;

namespace CarSalon.Web.Models
{
    public class ShopOrderVm
    {
       /* public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public CarType CarType { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }*/

        public OrderEntity Order { get; set; }


/*
        private readonly IOrderRepository _orderRepository;*/
   /*     public ShopOrderVm(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public bool InsertOrder()
        {
            _orderRepository.Add(new OrderEntity
            {
                Id = 1,
                Name = "Cristiano",
                Surname = "Ronaldo",
                CarType = CarType.Passenger,
                Price = 400000,
                IsNew = false,
                PhoneNumber = 123987645
            });
            return true;
        }
*/
        
    }
}

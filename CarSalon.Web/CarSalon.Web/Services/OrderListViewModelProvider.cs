using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models;
using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Services
{
    public interface IOrderListViewModelProvider
    {
        AdministrationOrderListVm PreperIndexVm();
    }

    public class OrderListViewModelProvider : IOrderListViewModelProvider
    {
        private readonly IOrderRepository _orderRepository;

        public OrderListViewModelProvider(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public AdministrationOrderListVm PreperIndexVm()
        {
            var orders = _orderRepository
                .All()
                .Select(n => new OrderDto(n))
                .ToList();

            var number = _orderRepository.Count();

            return new AdministrationOrderListVm(){ Orders = orders, OrderNumber = number };
        }
    }
}

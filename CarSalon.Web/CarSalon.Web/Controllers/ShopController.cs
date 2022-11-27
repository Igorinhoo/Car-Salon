using CarSalon.Web.Data;
using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace CarSalon.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly IDetailsViewModelProvider _detailsViewModelProvider;
        private readonly IModelRepository _modelRepository;
        private readonly IOrderRepository _orderRepository;


        public ShopController(IDetailsViewModelProvider detailsViewModelProvider, IModelRepository modelRepository, IOrderRepository orderRepo)
        {
            _detailsViewModelProvider = detailsViewModelProvider;
            _modelRepository = modelRepository;
            _orderRepository = orderRepo;
        }
        public IActionResult Order()
        {         
            return View();
        }

        public IActionResult Details(int id)
        {
            var viewmodel = _modelRepository.One(id);
            /*var vm = _detailsViewModelProvider.PreperIndexVm(id);*/
            return View(viewmodel);
           
        }

        public IActionResult Add(OrderEntity Order)
        {
            var viemodel = _orderRepository.Add(Order);
            return RedirectToAction("Order");
        }


    }
}

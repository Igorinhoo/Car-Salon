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
        private readonly IModelsViewModelProvider _modelsViewModelProvider;
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IOrderRepository _orderRepository;


        public ShopController(IDetailsViewModelProvider detailsViewModelProvider, IModelsViewModelProvider modelsViewModelProvider ,IBrandRepository brandRepository, IModelRepository modelRepository, IOrderRepository orderRepo)
        {
                 _detailsViewModelProvider = detailsViewModelProvider;
                 _modelsViewModelProvider = modelsViewModelProvider;
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
            _orderRepository = orderRepo;
        }
        public IActionResult Order()
        {         
            return View();
        
        }

        public IActionResult BrandModels(int id)
        {
            var viewmodel = _modelsViewModelProvider.PreperIndexVm(id);
            return View(viewmodel);
        }

        public IActionResult Details(int id)
        {
           
            var vm = _detailsViewModelProvider.PreperIndexVm(id);
            return View(vm);
           
        }

        public IActionResult Add(OrderEntity Order)
        {
            var viemodel = _orderRepository.Add(Order);
            return RedirectToAction("Order");
        }


    }
}

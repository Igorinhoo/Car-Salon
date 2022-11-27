using CarSalon.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CarSalon.Web.Services;
using CarSalon.Web.Data.Repositories;

namespace CarSalon.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShopViewModelProvider _shopViewModelProvider;
        private readonly IModelRepository _modelRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IShopViewModelProvider shopViewModelProvider, IModelRepository modelRepository, IBrandRepository brandRepository)
        {
            _shopViewModelProvider = shopViewModelProvider;
            _modelRepository = modelRepository;
            _logger = logger;
            _brandRepository = brandRepository;
        }

        public IActionResult Index()
        {
            var viewmodel = _shopViewModelProvider.PreperIndexVm();
            /*_modelRepository.Add(new Data.ModelEntity
            {
                Id = 6,
                Name = "500",
                MadeIn = DateTime.Now.AddYears(-5),
                Price = 120000,
                IsNew = false,
                CarType = Data.CarType.Passenger,
                Fuel = Data.Fuel.Hybrid,
                BrandForeignKey = 3,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });*/
/*
            _brandRepository.Add(new Data.BrandEntity
            {
                Id = 7,
                Name = "Ferrari"
            });*/
            return View(viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
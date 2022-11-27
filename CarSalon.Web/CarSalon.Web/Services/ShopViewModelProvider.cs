using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models;
using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Services
{
    public interface IShopViewModelProvider
    {
        HomeIndexVm PreperIndexVm();
    }

    public class ShopViewModelProvider : IShopViewModelProvider
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;

        public ShopViewModelProvider(IBrandRepository brandRepository, IModelRepository modelRepository)
        {
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
        }

        public HomeIndexVm PreperIndexVm()
        {
            var brands = _brandRepository
                .All()
                .Select(n => new BrandDto(n))
                .ToList();

            var mod = _modelRepository.All().Select(n => new ModelDto(n)).ToList();



            return new HomeIndexVm(){ Brands = brands };
        }
    }
}

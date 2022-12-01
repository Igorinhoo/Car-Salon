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

        public ShopViewModelProvider(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public HomeIndexVm PreperIndexVm()
        {
            var brands = _brandRepository
                .All()
                .Select(n => new BrandDto(n))
                .ToList();

            return new HomeIndexVm(){ Brands = brands };
        }
    }
}

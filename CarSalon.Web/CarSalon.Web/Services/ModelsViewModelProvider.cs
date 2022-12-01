using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models;
using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Services
{
    public interface IModelsViewModelProvider
    {
        ShopBrandModelsVm PreperIndexVm(int Id);
    }

    public class ModelsViewModelProvider : IModelsViewModelProvider
    {
   
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;

        public ModelsViewModelProvider(IBrandRepository brandRepository, IModelRepository modelRepository)
        {
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
        }

        public ShopBrandModelsVm PreperIndexVm(int Id)
        {
            var models = _modelRepository
                .All(Id)
                .Select(n => new ModelDto(n))
                .ToList();




            return new ShopBrandModelsVm(){ Models = models};
        }
    }
}

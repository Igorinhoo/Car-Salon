using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models;
using CarSalon.Web.Models.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarSalon.Web.Services
{
    public interface IStatisticsViewModelProvider
    {
        AdministrationStatisticsVm PreperIndexVm();

    }

    public class StatisticsViewModelProvider : IStatisticsViewModelProvider
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;

        public StatisticsViewModelProvider(IBrandRepository brandRepository, IModelRepository modelRepository)
        {
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
        }

        public AdministrationStatisticsVm PreperIndexVm()
        {
           

            var brands = _brandRepository.All().Select(n => new BrandDto(n)).ToList();

            var models = _modelRepository.All().Select(n => new ModelDto(n)).ToList();



            return new AdministrationStatisticsVm(){ Brands = brands, Models = models };
        }
    }
}

using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models;
using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Services
{
    public interface IAddViewModelProvider
    {
        AdministratioAddVm PreperIndexVm();
    }

    public class AddViewModelProvider : IAddViewModelProvider
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IEquipmentRepository _equipmentRepository;

        public AddViewModelProvider(IBrandRepository brandRepository, IEquipmentRepository equipmentRepository, IModelRepository modelRepository)
        {
            _brandRepository = brandRepository;
            _equipmentRepository = equipmentRepository;
            _modelRepository = modelRepository;
        }

        public AdministratioAddVm PreperIndexVm()
        {
            var brands = _brandRepository
                .All()
                .Select(n => new BrandDto(n))
                .ToList();

            var mod = _modelRepository
                .All()
                .Select(n => new ModelDto(n))
                .ToList();

            var equip = _equipmentRepository
                .All()
                .Select(n => new EquipmentDto(n))
                .ToList();


            return new AdministratioAddVm() { BrandsList = brands, EquipmentsList = equip, ModelsList = mod };
        }
    }
}

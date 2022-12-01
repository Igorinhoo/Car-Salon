using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models;
using CarSalon.Web.Models.DTOs;
using System.Diagnostics.Metrics;

namespace CarSalon.Web.Services
{
    public interface IAllThingsViewModelProvider
    {
        AdministrationUpdateVm PreperIndexVm();
    }

    public class AllThingsViewModelProvider : IAllThingsViewModelProvider
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IModelEquipmentRepository _modelEquipmentRepository;

        public AllThingsViewModelProvider(IBrandRepository brandRepository, IEquipmentRepository equipmentRepository, IModelRepository modelRepository, IModelEquipmentRepository modelEquipmentRepository)
        {
            _brandRepository = brandRepository;
            _equipmentRepository = equipmentRepository;
            _modelRepository = modelRepository;
            _modelEquipmentRepository = modelEquipmentRepository;
        }

        public AdministrationUpdateVm PreperIndexVm()
        {
            var brands = _brandRepository
                .All()
                .Select(n => n)
                .ToList();

            var mod = _modelRepository
                .All()
                .Select(n => n)
                .ToList();

            var equip = _equipmentRepository
                .All()
                .Select(n => n)
                .ToList();

            var model_equip = _modelEquipmentRepository
                .All()
                .Select(n => n)
                .ToList();

            var branCou = _brandRepository.Count();
            var modelCou = _modelRepository.Count();
            var equipmentCou = _equipmentRepository.Count();
            var modEquipCou = _modelEquipmentRepository.Count();


            return new AdministrationUpdateVm() { BrandsList = brands, EquipmentsList = equip, ModelsList = mod, model_EquipmentList = model_equip, 
                BrandCount = branCou, ModelCount = modelCou, EquipmentCount = equipmentCou, Model_EquipmentCount = modEquipCou
            };
        }

    }
}

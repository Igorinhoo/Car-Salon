using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models;
using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Services
{
    public interface IDetailsViewModelProvider
    {
        ShopDetailsVm PreperIndexVm(int Id);
    }

    public class DetailsViewModelProvider : IDetailsViewModelProvider
    {
        private readonly IModelEquipmentRepository _modelEquipmentRepository;
        private readonly IModelRepository _modelRepository;

        public DetailsViewModelProvider(IModelEquipmentRepository equipmentRepository, IModelRepository modelRepository)
        {
            _modelEquipmentRepository = equipmentRepository;
            _modelRepository = modelRepository;
        }

        public ShopDetailsVm PreperIndexVm(int Id)
        {
            var equip = _modelEquipmentRepository
                .AllForModel(Id)
                .Select(n => new EquipmentDto(n))
                .ToList();

            var mod = new ModelDto( _modelRepository.One(Id));



            return new ShopDetailsVm() { Equipmentes = equip, Models = mod };
        }
    }
}

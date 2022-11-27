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
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IModelRepository _modelRepository;

        public DetailsViewModelProvider(IEquipmentRepository equipmentRepository, IModelRepository modelRepository)
        {
            _equipmentRepository = equipmentRepository;
            _modelRepository = modelRepository;
        }

        public ShopDetailsVm PreperIndexVm(int Id)
        {
            var equip = _equipmentRepository
                .All(Id)
                .Select(n => new EquipmentDto(n))
                .ToList();

            var mod = _modelRepository.All().Select(n => new ModelDto(n)).ToList();



            return new ShopDetailsVm(){ Equipmentes = equip};
        }
    }
}

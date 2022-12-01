using CarSalon.Web.Data;
using CarSalon.Web.Data.Repositories;

using CarSalon.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarSalon.Web.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly IStatisticsViewModelProvider _statisticsViewModelProvider;
        private readonly IOrderListViewModelProvider _orderListViewModelProvider;
        private readonly IAddViewModelProvider _addViewModelProvider;
        private readonly IAllThingsViewModelProvider _allThingsViewModelProvider;
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IModelEquipmentRepository _modelEquipmentRepository;


        public AdministrationController(IStatisticsViewModelProvider statisticsViewModelProvider, IOrderListViewModelProvider orderListViewModelProvider, IAddViewModelProvider addViewModelProvider, IAllThingsViewModelProvider allThingsViewModelProvider, IBrandRepository brandRepository, IModelRepository modelRepository, IEquipmentRepository equipmentRepository, IModelEquipmentRepository modelEquipmentRepository)
        {
            _statisticsViewModelProvider = statisticsViewModelProvider;
            _orderListViewModelProvider = orderListViewModelProvider;
            _addViewModelProvider = addViewModelProvider;
            _allThingsViewModelProvider = allThingsViewModelProvider;
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
            _equipmentRepository = equipmentRepository;
            _modelEquipmentRepository = modelEquipmentRepository;

        }

        public IActionResult Main()
        {
            return View();
        }
        public IActionResult Statistics()
        {
            var viewmodel = _statisticsViewModelProvider.PreperIndexVm();
            return View(viewmodel);
        }
        public IActionResult OrderList()
        {
            var vm = _orderListViewModelProvider.PreperIndexVm();
            return View(vm);
        }
        public IActionResult AddView()
        {
            var viewmodel = _addViewModelProvider.PreperIndexVm();
            return View(viewmodel);
        }
    
        public IActionResult AllThings()
        {
            var viewmodel = _allThingsViewModelProvider.PreperIndexVm();
            return View(viewmodel);
        }
        public IActionResult AddBrand(BrandEntity Brand)
        {
            var model = _brandRepository.Add(Brand);
            return RedirectToAction("AddView");
        }

        public IActionResult AddModel(ModelEntity Model)
        {

            var model = _modelRepository.Add(Model);
            return RedirectToAction("AddView");
        }
        public IActionResult AddEquipment(EquipmentEntity Equipment)
        {

            var model = _equipmentRepository.Add(Equipment);
            return RedirectToAction("AddView");
        }
        public IActionResult AddModelEquipmentRelation(Model_EquipmentEntity Model_Equipment)
        {

            var model = _modelEquipmentRepository.Add(Model_Equipment);
            return RedirectToAction("AddView");
        }


        public IActionResult UpdateBrand(BrandEntity Brand)
        {
            var model = _brandRepository.Edit(Brand);
            return RedirectToAction("AllThings");
        }

        public IActionResult UpdateModel(ModelEntity Model)
        {
            var model = _modelRepository.Edit(Model);
            return RedirectToAction("AllThings");
        }
        public IActionResult UpdateEquipment(EquipmentEntity Equipment)
        {

            var model = _equipmentRepository.Edit(Equipment);
            return RedirectToAction("AllThings");
        }
        public IActionResult UpdateModelEquipmentRelation(Model_EquipmentEntity Model_Equipment)
        {

            var model = _modelEquipmentRepository.Edit(Model_Equipment);
            return RedirectToAction("AllThings");
        }

        public IActionResult DeleteBrand(BrandEntity BrandDel)
        {
            var model = _brandRepository.Delete(BrandDel.Id);
            return RedirectToAction("AllThings");
        }

        public IActionResult DeleteModel(ModelEntity ModelDel)
        {
            var model = _modelRepository.Delete(ModelDel.Id);
            return RedirectToAction("AllThings");
        }
        public IActionResult DeleteEquipment(EquipmentEntity EquipmentDel)
        {

            var model = _equipmentRepository.Delete(EquipmentDel.Id);
            return RedirectToAction("AllThings");
        }
        public IActionResult DeleteModelEquipmentRelation(Model_EquipmentEntity Model_EquipmentDel)
        {

            var model = _modelEquipmentRepository.Delete(Model_EquipmentDel.Id);
            return RedirectToAction("AllThings");
        }
    }
}

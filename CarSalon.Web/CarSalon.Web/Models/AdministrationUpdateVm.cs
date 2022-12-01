using CarSalon.Web.Data;
using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.InteropServices;

namespace CarSalon.Web.Models
{
    public class AdministrationUpdateVm
    {
        public BrandEntity Brand { get; set; }
        public ModelEntity Model { get; set; }
        public EquipmentEntity Equipment { get; set; }
        public Model_EquipmentEntity Model_Equipment { get; set; }

        public BrandEntity BrandDel { get; set; }
        public ModelEntity ModelDel { get; set; }
        public EquipmentEntity EquipmentDel { get; set; }
        public Model_EquipmentEntity Model_EquipmentDel { get; set; }

        public ICollection<BrandEntity> BrandsList { get; set; }
        public ICollection<ModelEntity> ModelsList { get; set; }
        public ICollection<EquipmentEntity> EquipmentsList { get; set; }
        public ICollection<Model_EquipmentEntity> model_EquipmentList { get; set; }

        public int BrandCount { get; set; }
        public int ModelCount { get; set; }
        public int EquipmentCount { get; set; }
        public int Model_EquipmentCount { get; set; }
    }
}

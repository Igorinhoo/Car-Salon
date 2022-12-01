using CarSalon.Web.Data;
using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Models.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.InteropServices;

namespace CarSalon.Web.Models
{
    public class AdministratioAddVm
    {
        public BrandEntity Brand { get; set; }
        public ModelEntity Model { get; set; }
        public EquipmentEntity Equipment { get; set; }
        public Model_EquipmentEntity Model_Equipment { get; set; }

        public ICollection<BrandDto> BrandsList { get; set; }
        public ICollection<ModelDto> ModelsList { get; set; }
        public ICollection<EquipmentDto> EquipmentsList { get; set; }
    }
}

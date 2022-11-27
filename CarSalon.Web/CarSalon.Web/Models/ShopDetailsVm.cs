using CarSalon.Web.Data;
using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Models
{
    public class ShopDetailsVm
    {
        public ICollection<EquipmentDto> Equipmentes { get; set; }
        
    }
}

using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Models
{
    public class AdministrationOrderListVm
    {
        public ICollection<OrderDto> Orders { get; set; }
        public int OrderNumber { get; set; }
    }
}

using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Models
{
    public class HomeIndexVm
    {

        public ICollection<BrandDto> Brands { get; set; }
    }
}

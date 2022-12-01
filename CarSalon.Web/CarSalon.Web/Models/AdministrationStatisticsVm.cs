using CarSalon.Web.Models.DTOs;

namespace CarSalon.Web.Models
{
    public class AdministrationStatisticsVm
    {
        public ICollection<BrandDto> Brands { get; set; }
        public ICollection<ModelDto> Models { get; set; }
        /*  ICollection<double> Count { get; set; }*/
    }
}

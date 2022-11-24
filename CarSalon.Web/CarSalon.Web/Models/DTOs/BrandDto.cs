using CarSalon.Web.Data;
using System.Diagnostics;

namespace CarSalon.Web.Models.DTOs
{
    public class BrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelDto> Models { get; set; }

        public BrandDto(BrandEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            if (entity.Models != null)
            {
                Models = entity.Models.Select(n => new ModelDto(n)).ToList();
            }
        }

        public BrandEntity ParseToEntity()
        {
            return new BrandEntity
            {
                Id = this.Id,
                Name = this.Name,

            };
        }
    }
}

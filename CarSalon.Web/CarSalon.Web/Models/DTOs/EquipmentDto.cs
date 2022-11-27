using CarSalon.Web.Data;

namespace CarSalon.Web.Models.DTOs
{
    public class EquipmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ModelForeignKey { get; set; }

        public EquipmentDto(EquipmentEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        
        }

        public EquipmentEntity ParseToEntity()
        {
            return new EquipmentEntity
            {
                Id = this.Id,
                Name = this.Name,
            };
        }
    }
}

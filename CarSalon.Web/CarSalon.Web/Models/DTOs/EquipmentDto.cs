using CarSalon.Web.Data;

namespace CarSalon.Web.Models.DTOs
{
    public class EquipmentDto
    {
        public int Id { get; set; }
        public int DoorsNumber { get; set; }
        public bool FourWheelDrive { get; set; }

        public ICollection<ModelDto> Models { get; set; }

        public EquipmentDto(EquipmentEntity entity)
        {
            Id = entity.Id;
            DoorsNumber = entity.DoorsNumber;
            if(entity.Models != null) { 
                Models = entity.Models.Select(n => new ModelDto(n)).ToList();
            }
        }

        public EquipmentEntity ParseToEntity()
        {
            return new EquipmentEntity
            {
                Id = this.Id,
                DoorsNumber = this.DoorsNumber,
                FourWheelDrive = this.FourWheelDrive,
            };
        }
    }
}

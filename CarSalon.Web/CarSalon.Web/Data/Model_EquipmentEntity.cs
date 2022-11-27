using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarSalon.Web.Data
{
    public class Model_EquipmentEntity
    {
        public int Id { get; set; }

        public ModelEntity model { get; set; }
        public int ModelId { get; set; }


        public EquipmentEntity equipment { get; set; }
        public int EquipmentId { get; set; }
    }
}

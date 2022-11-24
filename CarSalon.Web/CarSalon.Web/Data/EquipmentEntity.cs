namespace CarSalon.Web.Data
{

    public class EquipmentEntity
    {
        public int Id { get; set; }
        public int DoorsNumber { get; set; } 
        public bool FourWheelDrive { get; set; }

        public ICollection<ModelEntity> Models{ get; set; }
        

    }
}

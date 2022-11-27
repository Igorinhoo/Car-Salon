namespace CarSalon.Web.Data
{

    public class EquipmentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

 
        public ICollection<Model_EquipmentEntity> ModelEquipments { get; set; }



    }
}

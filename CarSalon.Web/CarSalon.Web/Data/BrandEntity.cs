namespace CarSalon.Web.Data
{
    public class BrandEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ModelEntity> Models { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public BrandEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

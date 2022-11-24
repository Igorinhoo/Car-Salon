using CarSalon.Web.Data;

namespace CarSalon.Web.Models.DTOs
{
    public class ModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MadeIn { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public Fuel Fuel { get; set; }
        public CarType CarType { get; set; }
        public int BrandForeignKey { get; set; }
        public ModelDto(ModelEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            MadeIn = entity.MadeIn;
            Price = entity.Price;
            IsNew = entity.IsNew;
            Fuel = entity.Fuel;
            CarType = entity.CarType;
            BrandForeignKey = entity.BrandForeignKey;
        }

        public ModelEntity ParseToEntity()
        {
            return new ModelEntity
            {
                Id = this.Id,
                Name = this.Name,
                MadeIn = this.MadeIn,
                Price = this.Price,
                IsNew = this.IsNew,
                Fuel = this.Fuel,
                CarType = this.CarType,
                BrandForeignKey = this.BrandForeignKey
            };
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Seeds
{
    public static class BrandSeeder
    {

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 1,
                    Name = "Audi",
                    ImgUrl = "https://brandslogos.com/wp-content/uploads/images/large/audi-logo.png"
                });
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 2,
                    Name = "BMW",
                    ImgUrl = "img/Brands/Bmw .png"
                });
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 3,
                    Name = "Fiat",
                    ImgUrl = "img/Brands/Fiat .png"
                });
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 4,
                    Name = "Porsche",
                    ImgUrl = "img/Brands/Porsche .png"
                });
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 5,
                    Name = "Jeep",
                    ImgUrl = "img/Brands/Jeep .png"
                });
            builder.Entity<BrandEntity>()
             .HasData(new BrandEntity()
                 {
                     Id = 6,
                     Name = "Mercedes",
                    ImgUrl = "img/Brands/Mercedes .png"
             });
        }
    }
}

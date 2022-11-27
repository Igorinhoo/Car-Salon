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
                });
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 2,
                    Name = "BMW",
                });
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 3,
                    Name = "Fiat",
                });
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 4,
                    Name = "Porsche",
                });
            builder.Entity<BrandEntity>()
                .HasData(new BrandEntity()
                {
                    Id = 5,
                    Name = "Jeep",
                });
            builder.Entity<BrandEntity>()
             .HasData(new BrandEntity()
                 {
                     Id = 6,
                     Name = "Mercedes",
                 });
        }
    }
}

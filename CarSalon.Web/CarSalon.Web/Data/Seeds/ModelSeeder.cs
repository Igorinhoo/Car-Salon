using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Seeds
{
    public static class ModelSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<ModelEntity>()
                .HasData(new ModelEntity()
                {
                    Id = 1,
                    Name = "M850i xDrive Coupé",
                    MadeIn = DateTime.Now.AddYears(-2),
                    Price = 700000f,
                    IsNew = true,
                    Fuel = Fuel.Petrol,
                    CarType = CarType.Passenger,
                    BrandForeignKey = 2,
                    
                });

            builder.Entity<ModelEntity>()
            .HasData(new ModelEntity()
                {
                    Id = 2,
                    Name = "Citaro",
                    MadeIn = DateTime.Now.AddYears(-4),
                    Price = 400000f,
                    IsNew = true,
                    Fuel = Fuel.Diesel,
                    CarType = CarType.Bus,
                    BrandForeignKey = 6,
                 
                });

            builder.Entity<ModelEntity>()
            .HasData(new ModelEntity()
                {
                    Id = 3,
                    Name = "Cayenne SUV",
                    MadeIn = DateTime.Now.AddYears(-2),
                    Price = 440000f,
                    IsNew = false,
                    Fuel = Fuel.Petrol,
                    CarType = CarType.Passenger,
                    BrandForeignKey = 4,
      
                });

            builder.Entity<ModelEntity>()
            .HasData(new ModelEntity()
                {
                    Id = 4,
                    Name = "Q5 II TFSI e",
                    MadeIn = DateTime.UtcNow,
                    Price = 600000f,
                    IsNew = true,
                    Fuel = Fuel.Hybrid,
                    CarType = CarType.Passenger,
                    BrandForeignKey = 1,

                });
            builder.Entity<ModelEntity>()
           .HasData(new ModelEntity()
               {
                   Id = 5,
                   Name = "Actros",
                   MadeIn = DateTime.Now.AddYears(-5),
                   Price = 400000f,
                   IsNew = false,
                   Fuel = Fuel.Diesel,
                   CarType = CarType.Truck,
                   BrandForeignKey = 6,

               });
        }
    }
}

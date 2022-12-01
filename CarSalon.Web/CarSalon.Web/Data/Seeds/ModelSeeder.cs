using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using CarSalon.Web.Data;

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
                    ImgUrl = "img/Models/M850i Coupé.png"
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
                    ImgUrl = "img/Models/citaro.png"
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
                    ImgUrl = "img/Models/Cayenne SUV.png"

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
                    ImgUrl = "img/Models/Q5 TFSI.png"

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
                   ImgUrl = "img/Models/actros.png"

           });

            builder.Entity<ModelEntity>()
               .HasData(new ModelEntity()
               {
                   Id = 6,
                   Name = "500",
                   MadeIn = DateTime.Now.AddYears(-5),
                   Price = 120000,
                   IsNew = false,
                   CarType = Data.CarType.Passenger,
                   Fuel = Data.Fuel.Hybrid,
                   BrandForeignKey = 3,
                   ImgUrl = "img/Models/500.png"

               });

            builder.Entity<ModelEntity>()
           .HasData(new ModelEntity()
           {
               Id = 7,
               Name = "Wrangler",
               MadeIn = DateTime.Now.AddYears(-4),
               Price = 361000,
               IsNew = true,
               CarType = CarType.Passenger,
               Fuel = Fuel.Hybrid,
               BrandForeignKey = 5,
               ImgUrl = "https://www.jeep.pl/content/dam/jeep/crossmarket/model/wrangler-4xe-my22/overview/colorizer/sahara/jeep-wrangler-4xe-sahara-black-565x330.png"

           });
            builder.Entity<ModelEntity>()
               .HasData(new ModelEntity()
               {
                   Id = 8,
                   Name = "Compass",
                   MadeIn = DateTime.Now.AddYears(-6),
                   Price = 410000,
                   IsNew = true,
                   CarType = CarType.Passenger,
                   Fuel = Fuel.Hybrid,
                   BrandForeignKey = 5,
                   ImgUrl = "https://www.jeep.pl/content/dam/jeep/crossmarket/compass-my-23/compass-ehybrid/overview/trim/trim-s/Jeep_Compass_eHybrid_S_SolidBlack.png"
               });

            builder.Entity<ModelEntity>()
               .HasData(new ModelEntity()
               {
                   Id = 9,
                   Name = "M MOTORSPORT",
                   MadeIn = DateTime.Now.AddYears(-1),
                   Price = 710000,
                   IsNew = true,
                   CarType = CarType.Racing,
                   Fuel = Fuel.Diesel,
                   BrandForeignKey = 2,
                   ImgUrl = "https://www.robomarkets.pl/uploads/news/2019/may/bmw-m-motorsport-sponsorship-05-2019/images/car-dtm-final.png"
               });
            builder.Entity<ModelEntity>()
               .HasData(new ModelEntity()
               {
                   Id = 10,
                   Name = "Panda",
                   MadeIn = DateTime.Now.AddYears(-6),
                   Price = 70000,
                   IsNew = false,
                   CarType = CarType.Passenger,
                   Fuel = Fuel.Hybrid,
                   BrandForeignKey = 3,
                   ImgUrl = "https://www.fiat.pl/content/dam/fiat/com/my23/panda/colorizer/white/Panda-figurini-colorizer-Gelato-White-desktop-680x430.png"
               });
        }
    }
}

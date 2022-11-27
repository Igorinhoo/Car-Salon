using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Seeds
{
    public static class EquipmentSeeder
    {
        public static void Seed(ModelBuilder builder) 
        {
            builder.Entity<EquipmentEntity>()
                .HasData(new EquipmentEntity()
                {
                    Id = 1,
                    Name = "Four Drive Wheel",
               
                });
            builder.Entity<EquipmentEntity>()
                 .HasData(new EquipmentEntity()
                 {
                     Id = 2,
                     Name = "Turbo",
                     
                 });
            builder.Entity<EquipmentEntity>()
                .HasData(new EquipmentEntity()
                {
                    Id = 3,
                    Name = "Manual Transmission",
                 
                });
            builder.Entity<EquipmentEntity>()
                .HasData(new EquipmentEntity()
                {
                    Id = 4,
                    Name = "Automatic Transmission",
                   
                });
            builder.Entity<EquipmentEntity>()
                .HasData(new EquipmentEntity()
                {
                    Id = 5,
                    Name = "Cabriolet",

                }); 
            builder.Entity<EquipmentEntity>()
                .HasData(new EquipmentEntity()
                {
                    Id = 6,
                    Name = "System ABS",

                });
            builder.Entity<EquipmentEntity>()
                .HasData(new EquipmentEntity()
                {
                    Id = 7,
                    Name = "Two doors",

                });
            builder.Entity<EquipmentEntity>()
               .HasData(new EquipmentEntity()
               {
                   Id = 8,
                   Name = "Five doors",

               });
            builder.Entity<EquipmentEntity>()
                 .HasData(new EquipmentEntity()
                 {
                     Id = 9,
                     Name = "Three doors",

                 });
        }
    }
}

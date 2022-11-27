using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Seeds
{
    public static class Model_EquipmentSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
               {
                   Id = 1,
                   ModelId = 1,
                   EquipmentId = 9
               });
            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
                {
                    Id = 2,
                    ModelId = 1,
                    EquipmentId = 6
                });
            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
                {
                    Id = 3,
                    ModelId = 1,
                    EquipmentId = 4
                });

            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
                {
                    Id = 4,
                    ModelId = 2,
                    EquipmentId = 7
                });
            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
                {
                    Id = 5,
                    ModelId = 2,
                    EquipmentId = 3
                });

            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
                {
                    Id = 6,
                    ModelId = 3,
                    EquipmentId = 8
                });
            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
                {
                    Id = 7,
                    ModelId = 3,
                    EquipmentId = 4
                });
            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
                {
                    Id = 8,
                    ModelId = 3,
                    EquipmentId = 1
                });
            builder.Entity<Model_EquipmentEntity>()
                .HasData(new Model_EquipmentEntity()
                {
                    Id = 9,
                    ModelId = 3,
                    EquipmentId = 6
                });

            builder.Entity<Model_EquipmentEntity>()
             .HasData(new Model_EquipmentEntity()
             {
                 Id = 10,
                 ModelId = 4,
                 EquipmentId = 8
             });
            builder.Entity<Model_EquipmentEntity>()
             .HasData(new Model_EquipmentEntity()
             {
                 Id = 11,
                 ModelId = 4,
                 EquipmentId = 6
             });
            builder.Entity<Model_EquipmentEntity>()
             .HasData(new Model_EquipmentEntity()
             {
                 Id = 12,
                 ModelId = 4,
                 EquipmentId = 4
             });

            builder.Entity<Model_EquipmentEntity>()
                 .HasData(new Model_EquipmentEntity()
                 {
                     Id = 13,
                     ModelId = 5,
                     EquipmentId = 6
                 });
            builder.Entity<Model_EquipmentEntity>()
               .HasData(new Model_EquipmentEntity()
               {
                   Id = 14,
                   ModelId = 5,
                   EquipmentId = 7
               });
            builder.Entity<Model_EquipmentEntity>()
               .HasData(new Model_EquipmentEntity()
               {
                   Id = 15,
                   ModelId = 5,
                   EquipmentId = 4
               });
        }
    }
}

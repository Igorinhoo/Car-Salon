using CarSalon.Web.Data.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<BrandEntity> Brands { get; set; }
        public DbSet<ModelEntity> Models { get; set; }
        public DbSet<EquipmentEntity> Equipment { get; set; }
        public DbSet<Model_EquipmentEntity> Model_Equipment { get; set; }
        public DbSet<OrderEntity> Order { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BrandEntity>()
                .HasMany(n => n.Models)
                .WithOne(n => n.Brand)
                .HasForeignKey(n => n.BrandForeignKey);

            builder.Entity<Model_EquipmentEntity>()
                .HasOne(n => n.model)
                .WithMany(n => n.ModelEquipments)
                .HasForeignKey(n => n.ModelId);

            builder.Entity<Model_EquipmentEntity>()
              .HasOne(n => n.equipment)
              .WithMany(n => n.ModelEquipments)
              .HasForeignKey(n => n.EquipmentId);

            BrandSeeder.Seed(builder);

            ModelSeeder.Seed(builder);

            EquipmentSeeder.Seed(builder);

            Model_EquipmentSeeder.Seed(builder);
        }
    }
    }
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<BrandEntity> Brands { get; set; }
        public DbSet<ModelEntity> Models { get; set; }
        public DbSet<EquipmentEntity> Equipment { get; set; }


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

            builder.Entity<EquipmentEntity>()
                .HasMany(n => n.Models)
                .WithOne(n => n.Equipment)
                .HasForeignKey(n => n.EquipmentForeignKey);
        }
    }
}
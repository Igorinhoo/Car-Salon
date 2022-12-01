using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Repositories
{
    public interface IBrandRepository
    {
        ICollection<BrandEntity> All();
        int Count();
        BrandEntity One(int id);
        bool Add(BrandEntity entity);
        BrandEntity Edit(BrandEntity entity);
        bool Delete(int id);

    }

    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BrandRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public BrandEntity One(int id)
        {
            return _dbContext.Brands.Include(n => n.Models).FirstOrDefault(n => n.Id == id) ?? new BrandEntity();
        }
        public bool Add(BrandEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Brands.Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<BrandEntity> All()
        {
            return _dbContext.Brands
                .Include(n => n.Models)
                .Select(n => n)
                .ToList();
        }

        public int Count()
        {
            return _dbContext.Brands.Count();
        }

        public BrandEntity Edit(BrandEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.Name = entity.Name;
            dbEntity.ImgUrl = entity.ImgUrl;
            dbEntity.UpdatedAt = DateTime.UtcNow;

            _dbContext.Brands.Update(dbEntity);
            _dbContext.SaveChanges();

            return dbEntity;
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            _dbContext.Brands.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }
    }
}

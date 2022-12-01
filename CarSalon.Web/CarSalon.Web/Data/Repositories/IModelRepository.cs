using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Repositories
{
    public interface IModelRepository
    {
        ICollection<ModelEntity> All();
        ICollection<ModelEntity> All(int parentId);


        int Count();
        int Count(int parentId);
        ModelEntity One(int id);
        bool Add(ModelEntity entity);
        ModelEntity Edit(ModelEntity entity);

        bool Delete(int id);
        bool UpdateViewNumber(int id);


    }

    public class ModelRepository : IModelRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ModelRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ModelEntity One(int id)
        {
            return _dbContext.Models.FirstOrDefault(n => n.Id == id) ?? new ModelEntity();
        }
        public bool Add(ModelEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Models.Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<ModelEntity> All()
        {
            return _dbContext.Models
                .Include(n => n.ModelEquipments)
                .Select(n => n)
                .ToList();
        }
        public ICollection<ModelEntity> All(int parentId)
        {
            return _dbContext.Models
                .Select(n => n)
                .Where(n => n.BrandForeignKey == parentId)
                .ToList();
        }

        public int Count()
        {
            return _dbContext.Models.Count();
        }


        public int Count(int parentId)
        {
            return _dbContext.Models.Where(n => n.BrandForeignKey == parentId).Count();

        }

        public bool UpdateViewNumber(int id)
        {
            var one = One(id);
            var two = new ModelEntity() { ViewNumber = 1 };


            _dbContext.Models.Update(two);
            return _dbContext.SaveChanges() > 0;
        }

        public ModelEntity Edit(ModelEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.Name = entity.Name;
            dbEntity.MadeIn = entity.MadeIn;
            dbEntity.Price = entity.Price;
            dbEntity.IsNew = entity.IsNew;
            dbEntity.Fuel = entity.Fuel;
            dbEntity.CarType = entity.CarType;
            dbEntity.BrandForeignKey = entity.BrandForeignKey;
            dbEntity.ViewNumber = entity.ViewNumber;
            dbEntity.ImgUrl = entity.ImgUrl;
            dbEntity.UpdatedAt = DateTime.UtcNow;

            _dbContext.Models.Update(dbEntity);
            _dbContext.SaveChanges();

            return dbEntity;
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            _dbContext.Models.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }
    }
}

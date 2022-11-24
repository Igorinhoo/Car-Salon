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
            _dbContext.Models.Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<ModelEntity> All()
        {
            return _dbContext.Models
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
            return _dbContext.Brands.Count();
        }


        public int Count(int parentId)
        {
            return _dbContext.Models.Where(n => n.BrandForeignKey == parentId).Count();

        }
    }
}

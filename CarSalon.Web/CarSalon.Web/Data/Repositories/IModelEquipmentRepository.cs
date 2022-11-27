using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Repositories
{
    public interface IModelEquipmentRepository
    {
        ICollection<EquipmentEntity> AllForModel(int modelId);
        ICollection<Model_EquipmentEntity> All();
        int Count();
        Model_EquipmentEntity One(int id);
        bool Add(Model_EquipmentEntity entity);

    }

    public class ModelEquipmentRepository : IModelEquipmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ModelEquipmentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Model_EquipmentEntity One(int id)
        {
            return _dbContext.Model_Equipment.FirstOrDefault(n => n.Id == id) ?? new Model_EquipmentEntity();
        }
        public bool Add(Model_EquipmentEntity entity)
        {
            _dbContext.Model_Equipment.Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<EquipmentEntity> AllForModel(int modelId)
        {
            return _dbContext.Model_Equipment.Where(p => p.ModelId == modelId).Select(n => n.equipment).ToList();
        }

        public int Count()
        {
            return _dbContext.Model_Equipment.Count();
        }

        public ICollection<Model_EquipmentEntity> All()
        {
            return _dbContext.Model_Equipment.Select(n => n).ToList();
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Repositories
{
    public interface IEquipmentRepository
    {
        ICollection<EquipmentEntity> All(int modelId);
        int Count();
        EquipmentEntity One(int id);
        bool Add(EquipmentEntity entity);

    }

    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EquipmentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public EquipmentEntity One(int id)
        {
            return _dbContext.Equipment.FirstOrDefault(n => n.Id == id) ?? new EquipmentEntity();
        }
        public bool Add(EquipmentEntity entity)
        {
            _dbContext.Equipment.Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<EquipmentEntity> All(int modelId)
        {
            return _dbContext.Model_Equipment.Where(p => p.ModelId == modelId).Select(n => n.equipment).ToList();
        }

        public int Count()
        {
            return _dbContext.Equipment.Count();
        }

    }
}

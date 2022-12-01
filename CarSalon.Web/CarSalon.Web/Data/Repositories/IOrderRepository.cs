using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Repositories
{
    public interface IOrderRepository
    {
        ICollection<OrderEntity> All();
        int Count();
        OrderEntity One(int id);
        bool Add(OrderEntity entity);

    }

    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public OrderEntity One(int id)
        {
            return _dbContext.Order.FirstOrDefault(n => n.Id == id) ?? new OrderEntity();
        }
        public bool Add(OrderEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;

            _dbContext.Order.Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<OrderEntity> All()
        {
            return _dbContext.Order.Select(n => n).ToList();
        }

        public int Count()
        {
            return _dbContext.Order.Count();
        }

    }
}

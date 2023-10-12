using SEDC.PizzaApp.DataAccess.Data;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;

namespace SEDC.PizzaApp.DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private PizzaDbContext _dbContext;
        public OrderRepository(PizzaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> GetAll()
        {
            return _dbContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            Order order = _dbContext.Orders
                .Where(o => o.Id == id)
                .FirstOrDefault();

            return order;
        }

        public int Insert(Order entity)
        {
            _dbContext.Orders.Add(entity);
            _dbContext.SaveChanges();

            return entity.Id;
        }

        public void Update(Order entity)
        {
            _dbContext.Orders.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Order entity)
        {
            Order order = StaticDB.Orders
                .Where(o => o.Id == entity.Id)
                .FirstOrDefault();

            if (order == null)
                throw new Exception($"There is no record with {entity.Id}");
        
            StaticDB.Orders.Remove(order);
        }
    }
}

using SEDC.PizzaApp.DataAccess.Data;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;

namespace SEDC.PizzaApp.DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        public List<Order> GetAll()
        {
            return StaticDB.Orders;
        }

        public Order GetById(int id)
        {
            Order order = StaticDB.Orders
                .Where(o => o.Id == id)
                .FirstOrDefault();

            return order;
        }

        public int Insert(Order entity)
        {
            int newId = StaticDB.OrderId++;
            entity.Id = newId;

            StaticDB.Orders.Add(entity);

            return newId;
        }

        public void Update(Order entity)
        {
            Order order = StaticDB.Orders
                .Where(o => o.Id == entity.Id)
                .FirstOrDefault();

            int index = StaticDB.Orders.IndexOf(order);

            StaticDB.Orders[index] = entity;
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

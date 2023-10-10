using SEDC.PizzaApp.DataAccess.Data;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;

namespace SEDC.PizzaApp.DataAccess.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private PizzaDbContext _dbContext;

        public PizzaRepository(PizzaDbContext pizzaDbContext) 
        { 
            _dbContext = pizzaDbContext;
        }

        public List<Pizza> GetAll()
        {
            return _dbContext
                .Pizzas
                .ToList();
        }

        public Pizza GetById(int id)
        {
            Pizza pizza = _dbContext
                .Pizzas
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return pizza;
        }

        public int Insert(Pizza entity)
        {
            _dbContext.Pizzas.Add(entity);
            _dbContext.SaveChanges();

            return entity.Id;
        }

        public void Update(Pizza entity)
        {
            _dbContext.Pizzas.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Pizza entity)
        {
            _dbContext.Pizzas.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}

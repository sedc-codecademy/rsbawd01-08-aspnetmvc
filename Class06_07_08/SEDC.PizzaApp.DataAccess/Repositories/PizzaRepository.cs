using SEDC.PizzaApp.DataAccess.Data;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;

namespace SEDC.PizzaApp.DataAccess.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public List<Pizza> GetAll()
        {
            return StaticDB.Pizzas;
        }

        public Pizza GetById(int id)
        {
            Pizza pizza = StaticDB.Pizzas
                .Where(o => o.Id == id)
                .FirstOrDefault();

            return pizza;
        }

        public int Insert(Pizza entity)
        {
            int newId = StaticDB.PizzaId++;
            entity.Id = newId;

            StaticDB.Pizzas.Add(entity);

            return entity.Id;
        }

        public void Update(Pizza entity)
        {
            Pizza pizza = StaticDB.Pizzas
                .Where(o => o.Id == entity.Id)
                .FirstOrDefault();

            int index = StaticDB.Pizzas.IndexOf(pizza);

            StaticDB.Pizzas[index] = entity;
        }

        public void Delete(Pizza entity)
        {
            Pizza pizza = StaticDB.Pizzas
                .Where(o => o.Id == entity.Id)
                .FirstOrDefault();

            if (pizza == null)
                throw new Exception($"There is no record with {entity.Id}");

            StaticDB.Pizzas.Remove(pizza);
        }
    }
}

using SEDC.PizzaApp.DataAccess.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        // CRUD Methods

        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

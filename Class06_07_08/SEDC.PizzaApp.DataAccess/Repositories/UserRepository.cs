using SEDC.PizzaApp.DataAccess.Data;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public void Delete(User entity)
        {
            User user = StaticDB.Users.FirstOrDefault(x => x.Id == entity.Id);
            
            if (user == null)
                throw new Exception($"User with id {entity.Id} was not found");

            StaticDB.Users.Remove(user);
        }

        public List<User> GetAll()
        {
            return StaticDB.Users;
        }

        public User GetById(int id)
        {
            return StaticDB.Users.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(User entity)
        {
            entity.Id = ++StaticDB.UserId;

            StaticDB.Users.Add(entity);
            return entity.Id;
        }

        public void Update(User entity)
        {
            User user = StaticDB.Users.FirstOrDefault(x => x.Id == entity.Id);
            if (user == null)
            {
                throw new Exception($"User with id {entity.Id} was not found");
            }
            int index = StaticDB.Users.IndexOf(user);
            StaticDB.Users[index] = entity;
        }
    }
}

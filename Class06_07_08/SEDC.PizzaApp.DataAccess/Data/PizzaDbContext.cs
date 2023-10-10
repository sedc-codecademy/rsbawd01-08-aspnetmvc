using Microsoft.EntityFrameworkCore;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.DataAccess.Data
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        public PizzaDbContext(DbContextOptions options) : base(options) { }
    }
}

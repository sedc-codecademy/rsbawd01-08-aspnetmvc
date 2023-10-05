using SEDC.PizzaApp.DataAccess.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Data
{
    public static class StaticDB
    {
        public static int OrderId = 1;

        public static List<Pizza> Pizzas { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<PizzaOrder> PizzaOrders { get; set; }
        public static List<User> Users { get; set; }
    }
}

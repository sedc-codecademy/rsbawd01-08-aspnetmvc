using Microsoft.AspNetCore.Mvc;
using ViewsSample.Models;

namespace ViewsSample.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Order order = new Order()
            {
                Id = 1,
                Name = "Almir Vuk",
                PizzName = "Margarita",
                Price = 10,
                IsDelivered = true,
                HasExtras = true,

                Drinks = new List<string>() 
                { 
                    "Coca Cola 250ml",
                    "Fanta 250ml",
                    "Pepsi 1l"
                },

                ShopLocation = new ShopLocation() 
                { 
                    Address = "Oakvile 354 Str. Ontario 664",
                    Name = "Tratorria Uno",
                    WorkingTime = "08:00 - 23:00"
                }
            };

            return View(order);
        }
    }
}

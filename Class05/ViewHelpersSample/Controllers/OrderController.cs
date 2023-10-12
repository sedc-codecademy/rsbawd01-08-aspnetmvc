using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.BusinessLogic.Services.Interfaces;
using System.Diagnostics.Contracts;
using ViewHelpersSample.Models.ViewModels;

namespace ViewHelpersSample.Controllers
{
    public class OrderController : Controller
    {
        public OrderController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            OrderDetailsViewModel orderDetailsViewModel = new OrderDetailsViewModel()
            {
                CustomerName = "John Doe",
                Date = DateTime.Now,
                Name = "Pizza Order No:2993",
                Size = Enums.PizzaSize.Family
            };

            return View(orderDetailsViewModel);
        }

        [HttpGet]
        public IActionResult Create() 
        { 
            CreateOrderViewModel createOrderViewModel = new CreateOrderViewModel();

            return View(createOrderViewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateOrderViewModel model) 
        {
            if (model == null)
                throw new Exception("The value is not provided");

            // save to database
            
            string message = $"The order is successfully made by {model.CustomerName} " +
                $"and {model.PizzaName} will be delivered at {model.Address}";

            ViewData["Message"] = message;

            return View("Message");
        }
    }
}

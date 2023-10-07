using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.BusinessLogic.Services.Interfaces;
using SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IUserService _userService;
        // private IPizzaService _pizzaService;
        
        public OrderController(IOrderService orderService,
            IUserService userService)
        {
            _userService = userService;
            _orderService = orderService;
        }

        // Show page with the list of all orders in our database
        public IActionResult Index()
        {
            throw new NotImplementedException();
        }

        // Show page with details of Order
        public IActionResult Details(int? id)
        {
            throw new NotImplementedException();
        }

        // This is the action which will return the view with form for creating new Order
        public IActionResult Create()
        {
            throw new NotImplementedException();
        }

        // This action will be used for accepting the data from the form and passing it for business logic layer
        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            throw new NotImplementedException();
        }

        // This action will return the view for adding new pizza to existing order
        public IActionResult AddPizza(int id)
        {
            throw new NotImplementedException();
        }

        // This action will be used for accepting the data from the user and passing it next to business layer
        [HttpPost]
        public IActionResult AddPizza(PizzaOrderViewModel pizzaOrderViewModel)
        {
            throw new NotImplementedException();
        }

        // This action will return the view for editing order
        public IActionResult Edit(int? id)
        {
            throw new NotImplementedException();
        }

        // This action will be used for accepting the data from the user and passing it next to business layer
        [HttpPost]
        public IActionResult Edit(OrderViewModel orderViewModel)
        {
            throw new NotImplementedException();
        }

        // This action will return the view for deleting order
        public IActionResult Delete(int? id)
        {
            throw new NotImplementedException();
        }

        // This action will be used for accepting the data from the user and passing it next to business layer
        [HttpPost]
        public IActionResult Delete(OrderDetailsViewModel orderDetailsViewModel)
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.BusinessLogic.Services.Interfaces;
using SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IUserService _userService;
        private IPizzaService _pizzaService;
        
        public OrderController(IOrderService orderService,
            IUserService userService,
            IPizzaService pizzaService)
        {
            _userService = userService;
            _orderService = orderService;
            _pizzaService = pizzaService;
        }

        // Show page with the list of all orders in our database
        public IActionResult Index()
        {
            List<OrderListViewModel> listViewModel = _orderService.GetAllOrders();

            return View(listViewModel);
        }

        // Show page with details of Order
        public IActionResult Details(int? id)
        {
            throw new NotImplementedException();
        }

        // This is the action which will return the view with form for creating new Order
        [HttpGet]
        public IActionResult Create()
        {
            OrderViewModel orderViewModel = new OrderViewModel();

            ViewBag.Users = _userService.GetAllUsersForDropdown();

            return View(orderViewModel);
        }

        // This action will be used for accepting the data from the form and passing it for business logic layer
        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            _orderService.CreateOrder(orderViewModel);

            return RedirectToAction("Index");
        }

        // This action will return the view for adding new pizza to existing order
        public IActionResult AddPizza(int id)
        {
            PizzaOrderViewModel pizzaOrderViewModel = new PizzaOrderViewModel();

            pizzaOrderViewModel.OrderId = id;

            ViewBag.Pizzas = _pizzaService.GetPizzasForDropdown();

            return View(pizzaOrderViewModel);
        }

        // This action will be used for accepting the data from the user and passing it next to business layer
        [HttpPost]
        public IActionResult AddPizza(PizzaOrderViewModel pizzaOrderViewModel)
        {
            _orderService.AddPizzaToOrder(pizzaOrderViewModel);

            return RedirectToAction("Index");
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

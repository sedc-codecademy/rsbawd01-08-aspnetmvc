using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.BusinessLogic.Services.Interfaces;
using SEDC.PizzaApp.BusinessLogic.ViewModels.PizzaViewModel;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class PizzaController : Controller
    {
        private IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        public IActionResult Index()
        {
            List<PizzaViewModel> items = _pizzaService.GetPizzasForDropdown();

            return View(items);
        }
    }
}

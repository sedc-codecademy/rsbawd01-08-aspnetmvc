using SEDC.PizzaApp.BusinessLogic.Services.Interfaces;
using SEDC.PizzaApp.BusinessLogic.ViewModels.PizzaViewModel;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;

namespace SEDC.PizzaApp.BusinessLogic.Services
{
    // HomeWork
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepository;

        public PizzaService(IRepository<Pizza> pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public List<PizzaViewModel> GetPizzasForDropdown()
        {
            return _pizzaRepository
                .GetAll()
                .Select(p => new PizzaViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                }).ToList();
        }
    }
}

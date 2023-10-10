using SEDC.PizzaApp.BusinessLogic.ViewModels.PizzaViewModel;

namespace SEDC.PizzaApp.BusinessLogic.Services.Interfaces
{
    public interface IPizzaService
    {
        public List<PizzaViewModel> GetPizzasForDropdown();
    }
}

using ModelsSample.Models;

namespace ModelsSample.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel MapToPizzaViewModel(Pizza pizza) 
        {
            return new PizzaViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizaSize
            };
        }
    }
}

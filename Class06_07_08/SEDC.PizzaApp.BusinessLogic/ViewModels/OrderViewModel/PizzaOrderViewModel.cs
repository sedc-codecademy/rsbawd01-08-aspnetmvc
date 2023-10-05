using SEDC.PizzaApp.DataAccess.Domain.Enums;

namespace SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel
{
    public class PizzaOrderViewModel
    {
        public int OrderId { get; set; }

        public int PizzaId { get; set; }

        public PizzaSizeEnum PizzaSize { get; set; }
    }
}

using SEDC.PizzaApp.DataAccess.Domain.Enums;

namespace SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Location { get; set; }

        public PaymentMethodEnum PaymentMethod { get; set; }
    }
}

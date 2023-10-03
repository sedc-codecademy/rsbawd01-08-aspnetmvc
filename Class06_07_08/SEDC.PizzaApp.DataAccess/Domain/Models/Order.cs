using SEDC.PizzaApp.DataAccess.Domain.Enums;

namespace SEDC.PizzaApp.DataAccess.Domain.Models
{
    public class Order : BaseEntity
    {
        public bool Delivered { get; set; }
        public string Location { get; set; }
        public User User { get; set; }

        public PaymentMethodEnum PaymentMethod { get; set; }

        public List<PizzaOrder> PizzaOrders { get; set; }
    }
}

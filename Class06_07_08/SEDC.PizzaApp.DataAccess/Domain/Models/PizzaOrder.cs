namespace SEDC.PizzaApp.DataAccess.Domain.Models
{
    public class PizzaOrder : BaseEntity
    {
        public Order Order { get; set; }
        public int PizzaId { get; set; }

        public Pizza Pizza { get; set; }
        public int OrderId { get; set; }
    }
}

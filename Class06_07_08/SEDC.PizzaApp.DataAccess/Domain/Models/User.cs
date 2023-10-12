namespace SEDC.PizzaApp.DataAccess.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}

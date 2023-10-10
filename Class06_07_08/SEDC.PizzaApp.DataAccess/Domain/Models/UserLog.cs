namespace SEDC.PizzaApp.DataAccess.Domain.Models
{
    public class UserLog : BaseEntity
    {
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

namespace ModelsSample.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Pizza { get; set; }
        public double Price { get; set; }

        public User User { get; set; }
    }
}

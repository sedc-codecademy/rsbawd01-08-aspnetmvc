namespace ViewsSample.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PizzName { get; set; }
        public double Price { get; set; }

        public bool IsDelivered { get; set; }
        public bool HasExtras { get; set; }

        public List<string> Drinks { get; set; }

        public ShopLocation ShopLocation { get; set; }
    }

    public class ShopLocation 
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string WorkingTime { get; set; }
    }
}

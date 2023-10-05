namespace SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public bool Delivered { get; set; }
        public string Location { get; set; }

        public string UserFullName { get; set; }
        public string PaymentMethod { get; set; }
        public List<string> PizzaName { get; set; }
    }
}

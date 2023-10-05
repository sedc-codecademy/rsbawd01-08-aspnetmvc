namespace SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel
{
    public class OrderListViewModel
    {
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public bool Delivered { get; set; }
        public List<string> PizzaNames { get; set; }
    }
}

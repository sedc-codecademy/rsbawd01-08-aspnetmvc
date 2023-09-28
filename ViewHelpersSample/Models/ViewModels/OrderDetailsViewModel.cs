using ViewHelpersSample.Enums;

namespace ViewHelpersSample.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }


        public string Name { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }

        public PizzaSize Size { get; set; }
    }
}

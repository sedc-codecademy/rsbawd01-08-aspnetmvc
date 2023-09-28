using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ViewHelpersSample.Models.ViewModels
{
    public class CreateOrderViewModel
    {
        [Display(Name = "Ime kupca:")]
        public string CustomerName { get; set; }

        [Display(Name = "Naziv Pizze:")]
        public string PizzaName { get; set; }

        [Display(Name = "Veličina:")]
        public Size PizzaSize { get; set; }

        [Display(Name = "Adresa stanovanja:")]
        public string Address { get; set; }
    }
}

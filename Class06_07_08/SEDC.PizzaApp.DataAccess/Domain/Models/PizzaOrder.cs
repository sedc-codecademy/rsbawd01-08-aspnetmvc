using SEDC.PizzaApp.DataAccess.Domain.Enums;

namespace SEDC.PizzaApp.DataAccess.Domain.Models
{
    public class PizzaOrder : BaseEntity
    {
        public virtual Order Order { get; set; }
        public int PizzaId { get; set; }

        public virtual Pizza Pizza { get; set; }
        public int OrderId { get; set; }
        
        public PizzaSizeEnum PizzaSize { get; set; }
    }
}

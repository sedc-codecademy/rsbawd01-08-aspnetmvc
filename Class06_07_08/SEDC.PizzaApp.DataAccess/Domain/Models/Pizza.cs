﻿using SEDC.PizzaApp.DataAccess.Domain.Enums;

namespace SEDC.PizzaApp.DataAccess.Domain.Models
{
    public class Pizza : BaseEntity
    {
        public string Name { get; set; }
        public PizzaSizeEnum PizzaSize { get; set; }
        public bool IsOnPromotion { get; set; }
        public bool HasExtras { get; set; }

        public virtual List<PizzaOrder> PizzaOrders { get; set; }
    }
}

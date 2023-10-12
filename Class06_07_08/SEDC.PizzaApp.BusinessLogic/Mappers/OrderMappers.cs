using SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel;
using SEDC.PizzaApp.DataAccess.Domain.Models;

namespace SEDC.PizzaApp.BusinessLogic.Mappers
{
    public static class OrderMappers
    {
        public static Order MapToOrder
            (this OrderViewModel orderViewModel)
        {
            return new Order
            {
                Location = orderViewModel.Location,
                PaymentMethod = orderViewModel.PaymentMethod,
                PizzaOrders = new List<PizzaOrder>(),
            };
        }

        public static OrderDetailsViewModel MapToOrderDetailsViewModel
            (this Order order) 
        {
            return new OrderDetailsViewModel()
            {
                Delivered = order.Delivered,
                Id = order.Id,
                Location = order.Location,
                PaymentMethod = order.PaymentMethod.ToString(),
                UserFullName = order.User.FirstName + " " + order.User.LastName,
                PizzaName = order.PizzaOrders.Select(po => po.Pizza.Name).ToList()
            };
        }
    
        public static OrderListViewModel MapToOrderListViewModel
            (this Order order) 
        {
            return new OrderListViewModel()
            {
                Delivered = order.Delivered,
                Id = order.Id,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PizzaNames = order.PizzaOrders != null ? 
                
                order.PizzaOrders
                    .Select(p => p.Pizza.Name)
                     .ToList() : null
            };
        }
    
        public static OrderViewModel MapToOrderViewModel
            (this Order order) 
        {
            return new OrderViewModel()
            {
                Location = order.Location,
                PaymentMethod = order.PaymentMethod,
                UserId = order.User.Id,
                Id = order.Id
            };
        }
    }
}

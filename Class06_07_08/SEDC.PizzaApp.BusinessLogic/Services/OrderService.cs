using SEDC.PizzaApp.BusinessLogic.Services.Interfaces;
using SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.BusinessLogic.Services
{
    // HomeWork
    public class OrderService : IOrderService
    {
        // private IRepository<Order> _orderRepository;
        private OrderRepository _orderRepository;

        public void AddPizzaToOrder(PizzaOrderViewModel pizzaOrderViewModel)
        {
            throw new NotImplementedException();
        }

        public void CreateOrder(OrderViewModel orderViewModel)
        {
            _orderRepository.Insert(new Order());
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public void EditOrder(OrderViewModel orderViewModel)
        {
            throw new NotImplementedException();
        }

        public List<OrderListViewModel> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public OrderDetailsViewModel GetOrderDetails(int id)
        {
            throw new NotImplementedException();
        }

        public OrderViewModel GetOrderForEditing(int id)
        {
            throw new NotImplementedException();
        }
    }
}

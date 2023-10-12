using SEDC.PizzaApp.BusinessLogic.Mappers;
using SEDC.PizzaApp.BusinessLogic.Services.Interfaces;
using SEDC.PizzaApp.BusinessLogic.ViewModels.OrderViewModel;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;

namespace SEDC.PizzaApp.BusinessLogic.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;
        private IRepository<User> _userRepository;
        private IRepository<Pizza> _pizzaRepository;

        public OrderService(IRepository<Order> orderRepository, 
            IRepository<User> userRepository,
            IRepository<Pizza> pizzaRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _pizzaRepository = pizzaRepository;
        }

        public void CreateOrder(OrderViewModel orderViewModel)
        {
            int userId = orderViewModel.UserId;

            // Get user by id
            User user = _userRepository.GetById(userId);

            if (user == null)
                throw new Exception($"There is no user with {user.Id}");

            Order order = new Order()
            {
                Delivered = false,
                Location = orderViewModel.Location,
                PaymentMethod = orderViewModel.PaymentMethod,
                User = user
            };

            int newId = _orderRepository.Insert(order);

            if (newId == 0)
                throw new Exception($"There is an issue with inserting new order");
        }

        public OrderDetailsViewModel GetOrderDetails(int id)
        {
            Order orderDb = _orderRepository.GetById(id);

            if (orderDb == null)
                throw new Exception($"There is no order with order id: {id}");

            OrderDetailsViewModel orderDetailsViewModel = orderDb.MapToOrderDetailsViewModel();

            return orderDetailsViewModel;
        }

        public List<OrderListViewModel> GetAllOrders()
        {
            List<Order> orders = _orderRepository.GetAll();

            List<OrderListViewModel> ordersVM  = orders
                .Select(o => o.MapToOrderListViewModel())
                .ToList();

            return ordersVM;
        }

        public OrderViewModel GetOrderForEditing(int id)
        {
            Order orderDb = _orderRepository.GetById(id);

            if (orderDb == null)
                throw new Exception($"There is no order with order id: {id}");

            OrderViewModel viewModel = orderDb.MapToOrderViewModel();

            return viewModel;
        }

        public void EditOrder(OrderViewModel orderViewModel)
        {
            Order orderDb = _orderRepository.GetById(orderViewModel.Id);

            if (orderDb == null)
                throw new Exception($"There is no order with order id: {orderViewModel.Id}");

            User user = _userRepository.GetById(orderViewModel.UserId);

            if (user == null)
                throw new Exception($"There is no user with user id: {orderViewModel.UserId}");

            orderDb.Location = orderViewModel.Location;
            orderDb.PaymentMethod = orderViewModel.PaymentMethod;

            _orderRepository.Update(orderDb);
        }

        public void AddPizzaToOrder(PizzaOrderViewModel pizzaOrderViewModel)
        {
            Order orderDb = _orderRepository.GetById(pizzaOrderViewModel.OrderId);

            if (orderDb == null)
                throw new Exception($"There is no order with order id: { pizzaOrderViewModel.OrderId}");

            int pizzaId = pizzaOrderViewModel.PizzaId;

            Pizza pizza = _pizzaRepository.GetById(pizzaId);

            PizzaOrder pizzaOrder = new PizzaOrder()
            {
                Order = orderDb,
                OrderId = orderDb.Id,

                PizzaId = pizzaId,
                PizzaSize = pizzaOrderViewModel.PizzaSize,

                Pizza = pizza
            };

            orderDb.PizzaOrders.Add(pizzaOrder);
            
            // _dbContext.PizzaOrders.Inser(pizzaOrder);
            // _dbContext.SaveChanges();

            _orderRepository.Update(orderDb);
        }

        public void DeleteOrder(int id)
        {
            Order orderDb = _orderRepository.GetById(id);

            if (orderDb == null)
                throw new Exception($"The order with id {id} was not found!");

            _orderRepository.Delete(orderDb);
        }
    }
}

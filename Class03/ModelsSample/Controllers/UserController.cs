﻿using Microsoft.AspNetCore.Mvc;
using ModelsSample.Mappers;
using ModelsSample.Models;

namespace ModelsSample.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User person = new User() 
            { 
                Address = "Bob Str 124",
                FirstName = "Bob",
                LastName = "Bobsky",
                Phone = "089912909112"
            };

            Order order = new Order()
            {
                Id = 1,
                Pizza = "Margaritha",
                Price = 10.5,
                User = person
            };

            return View(order);
        }
    
        public IActionResult Details() 
        {
            Pizza pizza = new Pizza()
            {
                Id = 1,
                PizaSize = PizaSize.Familiy,
                Name = "Margarita",
                HasExtras = true,
                IsOnPromotion = true,
                Price = 10
            };

            PizzaViewModel pizzaViewModel = PizzaMapper.MapToPizzaViewModel(pizza);


            User person = new User()
            {
                Address = "Bob Str 124",
                FirstName = "Bob",
                LastName = "Bobsky",
                Phone = "089912909112"
            };

            Order order = new Order()
            {
                Id = 1,
                Pizza = "Margaritha",
                Price = 10.5,
                User = person
            };

            UserOrderDetailsViewModel viewModel = new UserOrderDetailsViewModel()
            {
                Phone = person.Phone,
                Address = person.Address,
                Pizza = order.Pizza,
                Price = order.Price,
                UserInfo = person.FirstName + " " + person.LastName
            };

            string userData = $"This content is generated by user at {DateTime.UtcNow}";

            // One of the approches to share data from controller to view (helper data)
            ViewData["Title"] = "Order page details";
            // ViewData["Biljana"] = userData;

            // Another way of passing data from controller to view (helper data)
            ViewBag.UserDataAndDate = userData;

            // Main way of passing data from action (controller) to view, main data is passed like this
            return View(viewModel);
        }
    }
}
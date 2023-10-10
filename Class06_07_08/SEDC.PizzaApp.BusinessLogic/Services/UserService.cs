using SEDC.PizzaApp.BusinessLogic.Mappers;
using SEDC.PizzaApp.BusinessLogic.Services.Interfaces;
using SEDC.PizzaApp.BusinessLogic.ViewModels.UserViewModel;
using SEDC.PizzaApp.DataAccess.Domain.Models;
using SEDC.PizzaApp.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserViewModel> GetAllUsersForDropdown()
        {
            List<User> users = _userRepository.GetAll();

            List<UserViewModel> viewModel = users
                .Select(u => u.MapToUserViewModel())
                .ToList();

            return viewModel;
        }
    }
}

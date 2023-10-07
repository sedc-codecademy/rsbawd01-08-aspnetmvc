using SEDC.PizzaApp.BusinessLogic.ViewModels.UserViewModel;
using SEDC.PizzaApp.DataAccess.Domain.Models;

namespace SEDC.PizzaApp.BusinessLogic.Mappers
{
    public static class UserMappers
    {
        public static UserViewModel MapToUserViewModel
            (this User user) 
        {
            return new UserViewModel()
            {
                FullName = user.FirstName + " " + user.LastName,
                Id = user.Id,
            };
        }
    }
}

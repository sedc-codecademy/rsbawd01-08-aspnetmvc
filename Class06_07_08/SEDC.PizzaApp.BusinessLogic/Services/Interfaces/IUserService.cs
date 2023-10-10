using SEDC.PizzaApp.BusinessLogic.ViewModels.UserViewModel;

namespace SEDC.PizzaApp.BusinessLogic.Services.Interfaces
{
    public interface IUserService
    {
        public List<UserViewModel> GetAllUsersForDropdown();
    }
}

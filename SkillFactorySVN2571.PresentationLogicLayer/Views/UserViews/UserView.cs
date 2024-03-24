using SkillFactorySVN2571.BusinessLogicLayer.Models;
using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.UserViews
{
    internal class UserView
    {
        private UserService _userService;
        public UserView()
        {
            _userService = new UserService();
            try
            {
                List<UserData> userData = _userService.GetAllUsers();
                foreach (UserData userDataItem in userData)
                {
                    Console.WriteLine($"Номер читательского билета: {userDataItem.Id}");
                    Console.WriteLine($"Имя: {userDataItem.Name}");
                    Console.WriteLine($"Фамилия: {userDataItem.LastName}");
                    Console.WriteLine($"eMail: {userDataItem.eMail}");
                    Console.WriteLine();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Пользователи не найдены");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}

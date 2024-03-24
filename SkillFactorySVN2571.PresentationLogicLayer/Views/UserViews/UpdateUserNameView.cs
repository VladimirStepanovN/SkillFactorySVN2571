using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.UserViews
{
    public class UpdateUserNameView
    {
        private UserService _userService;
        public UpdateUserNameView()
        {
            _userService = new UserService();
            Guid inputId;
            Console.WriteLine("Введите номер билета пользователя");
            try
            {
                inputId = Guid.Parse(Console.ReadLine());
                Console.WriteLine("Введите новое имя");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Имя пользователя не может быть пустым");
                }
                _userService.UpdateUserName(name, inputId);
                Console.WriteLine("Имя пользователя обновлено");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Пользователь с таким билетом не найдены");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}"); ;
            }
        }
    }
}

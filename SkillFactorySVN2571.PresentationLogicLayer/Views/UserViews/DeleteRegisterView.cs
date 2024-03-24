using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.UserViews
{
    public class DeleteRegisterView
    {
        private UserService _userService;

        public DeleteRegisterView()
        {
            _userService = new UserService();
            Console.WriteLine("Введите номер билета пользователя");
            try
            {
                Guid inputId = Guid.Parse(Console.ReadLine());
                _userService.DeleteRegister(inputId);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Пользователь с таким билетом не найдены");
            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректный Id");
            }
        }
    }
}

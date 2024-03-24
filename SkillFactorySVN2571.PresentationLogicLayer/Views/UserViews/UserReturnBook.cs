using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.UserViews
{
    public class UserReturnBook
    {
        private BookService _bookService;
        private UserService _userService;
        
        public UserReturnBook()
        {
            _bookService = new BookService();
            _userService = new UserService();
            try
            {
                Console.WriteLine("Введите регистрационный номер книги.");
                Guid inputBookId = Guid.Parse(Console.ReadLine());
                Console.WriteLine();
                var bookData = _bookService.FindBookById(inputBookId);
                if (bookData == null)
                {
                    throw new ArgumentNullException();
                }
                _userService.UserReturnBook(bookData.Id);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Пользователь или книга с такими данными не найдены");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}

using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.BookViews
{
    public class DeleteRegisterBookView
    {
        private BookService _bookService;

        public DeleteRegisterBookView()
        {
            _bookService = new BookService();
            try
            {
                Console.WriteLine("Введите регистрационный номер книги");
                Guid inputId = Guid.Parse(Console.ReadLine());
                _bookService.DeleteBook(inputId);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Книга с таким регистрационным номером не найдена");
            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректный Id");
            }
        }
    }
}

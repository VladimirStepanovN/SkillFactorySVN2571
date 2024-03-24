using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.BookViews
{
    public class UpdatePublishYearBookView
    {
        private BookService _bookService;

        public UpdatePublishYearBookView()
        {
            _bookService = new BookService();
            try
            {
                Console.WriteLine("Введите регистрационный номер книги");
                Guid inputId = Guid.Parse(Console.ReadLine());
                Console.WriteLine("Введите год публикации книги");
                int year;
                if (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.WriteLine("Значение недопустимо");
                    return;
                }
                _bookService.UpdateBookYear(inputId, year);
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

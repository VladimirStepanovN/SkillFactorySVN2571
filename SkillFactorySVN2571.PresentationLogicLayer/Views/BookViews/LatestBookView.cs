using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.BookViews
{
    public class LatestBookView
    {
        private BookService _bookService;

        public LatestBookView()
        {
            _bookService = new BookService();
            try
            {
                var bookData = _bookService.GetLatestBook();
                Console.WriteLine();
                Console.WriteLine($"Идентификатор: {bookData.Id}");
                Console.WriteLine($"Название: {bookData.Name}");
                Console.WriteLine($"Автор: {bookData.Author}");
                Console.WriteLine($"Жанр: {bookData.Genre}");
                Console.WriteLine($"Год издания: {bookData.Year}");
                Console.WriteLine();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Книги не найдены.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}

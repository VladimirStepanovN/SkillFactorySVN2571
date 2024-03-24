using SkillFactorySVN2571.BusinessLogicLayer.Models;
using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.BookViews
{
    public class AllBookSortedView
    {
        private BookService _bookService;

        public AllBookSortedView()
        {
            _bookService = new BookService();
            try
            {
                List<BookData> bookData = _bookService.GetAllSortedBooks();
                foreach (BookData bookDataItem in bookData)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Регистрационный номер книги: {bookDataItem.Id}");
                    Console.WriteLine($"Название: {bookDataItem.Name}");
                    Console.WriteLine($"Автор: {bookDataItem.Author}");
                    Console.WriteLine($"Жанр: {bookDataItem.Genre}");
                    Console.WriteLine($"Год издания: {bookDataItem.Year}");
                    Console.WriteLine();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Книги не найдены");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}

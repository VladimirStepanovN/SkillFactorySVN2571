﻿using SkillFactorySVN2571.BusinessLogicLayer.Models;
using SkillFactorySVN2571.BusinessLogicLayer.Services;

namespace SkillFactorySVN2571.PresentationLogicLayer.Views.BookViews
{
    public class BookByAuthorAndNameView
    {
        private BookService _bookService;

        public BookByAuthorAndNameView()
        {
            _bookService = new BookService();
            Console.WriteLine();
            Console.WriteLine("Введите имя автора книги");
            string author = Console.ReadLine();
            Console.WriteLine("Введите название книги");
            string name = Console.ReadLine();
            Console.WriteLine();
            try
            {
                if (_bookService.Exists(author, name))
                {
                    Console.WriteLine("Данная книга есть в библиотеке");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("К сожалению, данной книги нет в библиотеке");
                    Console.WriteLine();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Введены неверные данные");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}

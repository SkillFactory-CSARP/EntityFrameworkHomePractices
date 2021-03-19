using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _35_5
{
    public class BookRepository
    {
        private AppContext context = new AppContext();

        public Book GetBook(int id)
        {
            return context.Books.FirstOrDefault(u => u.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            return context.Books.ToList();
        }

        public void AddBook(Book book)
        {
            context.Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            context.Books.Remove(book);
        }

        public void UpdateBookYearOfRelease(int id, int yearOfRelease)
        {
            var book = context.Books.FirstOrDefault(u => u.Id == id);

            if (book != null)
            {
                book.YearOfRelease = yearOfRelease;
                context.SaveChanges();
            }
        }

        //Получаем количество книг определенного автора в библиотеке
        public int GetBooksCountByAuthorId(int authorId)
        {
            return context.Books.Where(b => b.AuthorId == authorId).Count();
        }

        //Получаем количество книг определенного жанра в библиотеке
        public int GetBooksCountByGenreId(int genreId)
        {
            return context.Books.Where(b => b.GenreId == genreId).Count();
        }

        //Получаем булевый флаг о том, есть ли книга определенного автора и названия в библиотеке
        public bool BookExistByBookNameAndAuthorId(string bookName, int authorId)
        {
            return context.Books.Any(b => b.Name == bookName && b.AuthorId == authorId);
        }

        //Получение последней вышедшей книги
        public Book GetLastBook()
        {
            return context.Books.OrderByDescending(b => b.YearOfRelease).First();
        }

        //Получение списка всех книг, отсортированного в алфавитном порядке по названию
        public List<Book> GetBooksOrderByName()
        {
            return context.Books.OrderBy(b => b.Name).ToList();
        }

        //Получение списка всех книг, отсортированного в порядке убывания года их выхода
        public List<Book> GetBooksOrderByDescendingByYearOfRelease()
        {
            return context.Books.OrderByDescending(b => b.YearOfRelease).ToList();
        }
    }
}

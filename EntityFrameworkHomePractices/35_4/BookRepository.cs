﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _35_4
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
    }
}

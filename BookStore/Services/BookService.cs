using BookStore.DBContexts;
using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly BookStoreDBContext context;

        public BookService( BookStoreDBContext context)
        {
            this.context = context;
        }

        public Book Create(Book book)
        {
            context.Add(book);
            var BookId = context.SaveChanges();

            return new Book()
            {
                BookId = BookId,
                BookName = book.BookName,
                Authors = book.Authors,
                Description = book.Description,
                Photo = book.Photo,
                IsDeleted = book.IsDeleted,
                CategoryId = book.CategoryId,
                PublishYear = book.PublishYear,
                Price = book.Price
            };
        }

        public Book GetBook(int bookId)
        {
            return context.Books.Include(c => c.Category).ToList().SingleOrDefault(b => b.BookId == bookId);
        }

        public List<Book> GetBooks()
        {
            return context.Books.Include(c => c.Category).ToList();
        }
    }
}

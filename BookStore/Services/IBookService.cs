using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBook(int bookId);
        Book Create(Book book);
    }
}

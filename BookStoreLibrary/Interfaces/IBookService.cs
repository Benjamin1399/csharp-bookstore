using BookStoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLibrary.Interfaces
{
    interface IBookService
    {
        bool AddBook(AddBookRequest request);

        Book GetBook(string title, string author);

        List<Book> SearchBooks(string title, string author);
    }
}

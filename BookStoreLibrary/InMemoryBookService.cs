using BookStoreLibrary.Interfaces;
using BookStoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLibrary
{
    public class InMemoryBookService : IBookService
    {
        List<Book> library = new List<Book>();

        public bool AddBook(AddBookRequest request)
        {
            Book newBook = new Book();
            newBook.Title = request.Title;
            newBook.Author = request.Author;
            newBook.Price = request.Price;
            newBook.Qty = request.Qty;

            library.Add(newBook);

            return true;
        }

        public Book GetBook(string title, string author)
        {
            foreach (Book book in library)
            {
                if (book.Title == title && book.Author == author)
                {
                    return book;
                }
            }

            return null;
        }

        public List<Book> SearchBooks(string title, string author)
        {
            List<Book> matchingBooks = new List<Book>();

            foreach (Book book in library)
            {
                if (book.Title == title && book.Author == author)
                {
                    matchingBooks.Add(book);
                }
            }

            return matchingBooks;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webgentel.BookStore.Models;
using Webgentel.BookStore.Repository;

namespace Webgentel.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository = null;
        public BookController()
        {
            this.bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data =  bookRepository.GetAllBooks();
            return View();
        }

        public Book GetBook(int id)
        {
            return bookRepository.GetBookById(id);
        }

        public List<Book> SearchBooks(string bookName, string authorName)
        {
            return bookRepository.SearchBook(bookName, authorName);
        }
    }
}
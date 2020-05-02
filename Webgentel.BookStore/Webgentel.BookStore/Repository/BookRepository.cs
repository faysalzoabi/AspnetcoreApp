using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentel.BookStore.Models;

namespace Webgentel.BookStore.Repository
{
    public class BookRepository
    {

        public List<Book> GetAllBooks()
        {
            return DataSource();
        }

        public Book GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Book> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }


        private List<Book> DataSource()
        {
            List<Book> listBooks = new List<Book>()
            {
                new Book(){Id=1, Title="MVC", Author="Faysal"},
                new Book(){Id=2, Title="C", Author="Hihsam"},
                new Book(){Id=3, Title="Python", Author="Soha"},
                new Book(){Id=4, Title="Java", Author="Idris"},

            };

            return listBooks;
        }
    }
}

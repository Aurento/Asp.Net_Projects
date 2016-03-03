using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1.Models
{
    public class BooksFactory
    {
        public static IEnumerable<Book> CreateBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book()
            {
                Author ="Курт Воннегут" ,
                Name = "\"Сирены Титана\""

            });
            books.Add(new Book()
            {
                Author = "Николай Чернышевский",
                Name = "\"Что делать?\""

            });
            books.Add(new Book()
            {
                Author = "Сергей Довлатов",
                Name = "\"Ремесло\""

            });
            return books;

        }
    }
}
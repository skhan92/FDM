using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Basket
    {
        public List<Book> books { get; set; }
        public Basket()
        {
            books = new List<Book>();
        }
        public List<Book> getBooksInBasket()
        {
            return books;
        }

        public void addBook(Book bookToAdd)
        {
            books.Add(bookToAdd);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDBookShop
{
    public class Catalogue
    {
        public List<Book> books { get; set; }

        public Catalogue()
        {
            books = new List<Book>();
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book RemoveBook(string ISBN)
        {
            Book b=null;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == ISBN)
                {
                    b=books[i];
                    books.Remove(books[i]);
                }
            }
            return b;
        }
    }
}

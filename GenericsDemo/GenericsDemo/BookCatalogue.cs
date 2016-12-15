using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{

    //BAD APPROACH - WOULD HAVE TO REMAKE A NEW CLASS FOR EACH CATALOGUE
    public class BookCatalogue
    {
        List<Book> books = new List<Book>();

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public void AddBook(Book bookToAdd)
        {
            books.Add(bookToAdd); 
        }
    }
}

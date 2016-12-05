using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Animal Farm", "George Orwell");
            book1.isbn = "123ABC";
            book1.price = 10.00;
            book1.numberOfPages = 200;

            Book book2 = new Book("The Alchemist", "Paulo Cuello");
            book2.isbn = "456DEF";
            book2.price = 100.00;
            book2.numberOfPages = 500;

            Book book3 = new Book("Harry Potter", "JK Rowling");
            book3.isbn = "789GHI";
            book3.price = 60.00;
            book3.numberOfPages = 2500;

            Book[] books = { book1, book2, book3 };

            Checkout myCheckout = new Checkout();

            double totalPrice = myCheckout.CalculateTotalPrice(books);

            System.Console.WriteLine("the total price of books is:" + totalPrice);

            System.Console.ReadLine();    
        }
    }
}

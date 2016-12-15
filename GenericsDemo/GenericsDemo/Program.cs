using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ItemCatalogue catalogue = new ItemCatalogue();

            //catalogue.AddItem(new Book() { id = 1, title = "Harry Potter", author = "JKowalski" });
            //catalogue.AddItem(new Dvd() { id = 2, title = "Robocop", releaseDate = new DateTime() });
            ////catalogue.AddItem(new Magazine());
            ////catalogue.AddItem(new AudioBook());
            ////catalogue.AddItem(new Games());

            //foreach (Item item in catalogue.items) //THIS IS THE PROBLEM W THIS SO CALLED BEST METHOD MANNN
            //{
            //    Console.WriteLine(item.title);
            //    Console.WriteLine(item.author);
            //    Console.WriteLine(item.ReleaseYear);
            //}

            Catalogue<Book> catalogueOfBooks = new Catalogue<Book>();
            catalogueOfBooks.AddItem(new Book());

            Catalogue<Dvd> catalogueOfDvd = new Catalogue<Dvd>();
            catalogueOfDvd.AddItem(new Dvd());

            Catalogue<Games> catalogueOfGames = new Catalogue<Games>();
            catalogueOfGames.AddItem(new Games());
        }
    }
}

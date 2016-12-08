using Mocking.BookShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseReader databaseReader = new DatabaseReader();
            StockChecker stockChecker = new StockChecker(databaseReader);

            int stock = stockChecker.NumberInStock("ABC123");

            Console.WriteLine("Number in stock: " + stock);
            Console.ReadLine();
        }
    }
}

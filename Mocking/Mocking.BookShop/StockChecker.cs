using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking.BookShop
{
    public class StockChecker
    {
        IDatabaseReader _databaseReader;

        public StockChecker(IDatabaseReader databaseReader)
        {
            _databaseReader = databaseReader;
        }

        public int NumberInStock(string isbn)
        {
            int stock = _databaseReader.ReadQuantity(isbn);

            return stock;
        }
    }
}

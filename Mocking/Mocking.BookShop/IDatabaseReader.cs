using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking.BookShop
{
    public interface IDatabaseReader
    {
        int ReadQuantity(string isbn);
    }

    public class DatabaseReader : IDatabaseReader
    {
        public int ReadQuantity(string isbn)
        {
            //In reality, we would write code to connect to the database 
            //Return whatever the database gives back
            return 0;
        }
    }
}

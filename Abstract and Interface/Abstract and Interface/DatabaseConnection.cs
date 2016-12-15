using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Interface
{
    interface DatabaseConnection
    {
        bool OpenConnectionToDatabase(string databaseAddress);
    }

    class MicrosoftDatabaseConnection : DatabaseConnection
    {

        public bool OpenConnectionToDatabase(string databaseAddress)
        {
            return true;
        }
    }

    class OracleDatabaseConnection : DatabaseConnection
    {

        public bool OpenConnectionToDatabase(string databaseAddress)
        {
            return false;
        }
    }
}

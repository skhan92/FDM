using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillars.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Base class - most senior class
            UserController userController = new UserController();
            userController.Login("Bart Simpson", "EatMyShorts");

            //Inherits from UserController, so gets all it's methods
            AdminController adminController = new AdminController();
            adminController.Login("Homer Simpson", "Doh");
            adminController.SetPermissions("Maggie Simpson");

            //Inherits from AdminController, so gets all it's methods and the UserController Methods
            SuperAdminController superAdminController = new SuperAdminController();
            superAdminController.Login("Marge Simpson", "hmmm...");
            superAdminController.SetPermissions("Lisa Simpson");

            //Admin inherits name and id from User
            Admin admin = new Admin();
            admin.id = 123;
            admin.name = "batman";
            admin.password = "robin";

            //Buyer inherits name and id from user
            Buyer buyer = new Buyer ();
            buyer.id = 456;
            buyer.name = "joker";

            //Can't instantantiate because this is an abstract class 
            //User user = new User();

            //MSDBConnection inherited its method from DatabaseConnection Interface
            MicrosoftDatabaseConnection dbCon = new MicrosoftDatabaseConnection();
            dbCon.OpenConnectionToDatabase("Address");

            //Even though these are abstract and interaces we can still construct any object that inherits from them
            User user = new Admin();
            DatabaseConnection dbConnection = new OracleDatabaseConnection();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillars.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginController loginController = new LoginController();
            loginController.Login(123);
            loginController.Login("123");
            loginController.Login("123@123.com", "123");

            AdminLoginController adminLoginController = new AdminLoginController();
            adminLoginController.Login("123");

            Console.ReadLine();
        }
    }
}

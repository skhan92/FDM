using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillars.Polymorphism
{
    class LoginController
    {
        public virtual void Login(string username)
        {
            Console.WriteLine("Logging in with username:" + username);
        }
        //This is Overloaded, w a different type of parameter
        public void Login(int id)
        {
            Console.WriteLine("Logging in with id:" + id);
        }
        //Overloaded with an extra parameter
        public void Login(string email, string password)
        {
            Console.WriteLine("Logging in with email:" + email + "and password:" + password);
        }


    }

    class AdminLoginController : LoginController
    {
        public override void Login(string username)
        {
            Console.WriteLine("Logging in admin with username:" + username);
        }
    }
}

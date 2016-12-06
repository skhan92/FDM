using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillars.Inheritance
{
    //This is an example of inheritance using concrete classes
    class UserController
    {
        public void Login(string username, string password)
        {
            Console.WriteLine("Logging in -" + username);
        }
    }

    class AdminController : UserController
    {
        public void SetPermissions(string username)
        {
            Console.WriteLine("Setting Permissions for -" + username);
        }
    }

    class SuperAdminController : AdminController
    {

    }
}

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFakeUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //This is for code first
            EntityFramework context = new EntityFramework();

            foreach (Users users in context.users)
            {
                Console.WriteLine(users.fullName);
            }
            Console.ReadLine();
        }
    }
}

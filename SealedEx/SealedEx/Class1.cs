using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedEx
{
    class SealedTest2
    {
        static void Main()
        {
            SealedClassCustomers sc = new SealedClassCustomers(); 
            sc.a = "Joe Bloggs"; 
            sc.b = "Jane Doe"; 
            Console.WriteLine("a = {0}, b = {1}", sc.a, sc.b); //Showing both customers names as called
            Console.ReadLine();
        }
    }
}

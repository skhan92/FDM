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
            SealedClass sc = new SealedClass();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine("a = {0}, a = {1}", sc.x, sc.y);
            Console.ReadLine();
        }
    }
}

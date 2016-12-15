using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHeapDemo
{
    class Program
    {
        
    
        static void Main(string[] args)
        {
            //int i = 10;
            //int j = 5;
            
            //SwapPrimitives(ref i, ref j);

            //Console.WriteLine("i is: " + i);
            //Console.WriteLine("j is: " + j);

            DvD dvd1 = new DvD();
            dvd1.title = "The Matrix";
            DvD dvd2 = new DvD();
            dvd2.title = "Dumbo";

            SwapObjects(dvd1, dvd2);

            Console.WriteLine("dvd1 is: " + dvd1.title);
            Console.WriteLine("dvd2 is: " + dvd2.title);

            Console.ReadLine();
        }

        private static void SwapObjects(DvD dvd1, DvD dvd2)
        {
            string temp = dvd1.title;
            dvd1.title = dvd2.title;
            dvd2.title = temp;
        }

        private static void SwapPrimitives(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
            if (i % 15 == 0)
            {   
                System.Console.WriteLine("Fizzbuzz");
            }
            else if (i % 5 == 0)
            {    
                System.Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0)
            {    
                System.Console.WriteLine("Fizz");
            } 
            else
            {
                System.Console.WriteLine(i);
            }
            }
            System.Console.ReadLine();
        }
    }
}

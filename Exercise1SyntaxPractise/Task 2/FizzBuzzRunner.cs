using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class FizzBuzzRunner
{
        public void FizzBuzz(int num) {
            for (int i = 1; i <= num; i++)
            {
                if (IsFizzBuzz(i) == true)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                
                else if (IsBuzz(i) == true)
                {
                    System.Console.WriteLine("Buzz");
                }

                else if (IsFizz(i) == true)
                {
                    System.Console.WriteLine("Fizz");
                }
                
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        private bool IsFizz(int num)
            {
            if (num % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            }

        private bool IsBuzz (int num)
            {
            if (num % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            }

        private bool IsFizzBuzz (int num)
            {
            if (num % 15 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            }
    
    }
}

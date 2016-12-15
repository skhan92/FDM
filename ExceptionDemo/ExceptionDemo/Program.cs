using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide(10, 2);

            Divide(20, 0);

            Console.ReadLine();
        }

        static int Divide(int number1, int number2)
        { 
            try
            {
                return number1 / number2;
            }
            catch (DivideByZeroException exception) //catch the exception, don't let it go
            {
                Console.WriteLine("You tried to divide by zero!");

                return 0;
            }
            finally
            {
                //THIS IS ALWAYS RUNNING
            }

            //DEFENSIVE CODING TO PREVENT EXCEPTION
            //Mostly the one to use, only use try, catch, finally if dealing w/ external database
            //if (number2 == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return number1 / number2;
            //}
        }        
    }
}

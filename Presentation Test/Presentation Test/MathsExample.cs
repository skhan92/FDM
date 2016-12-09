using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Test
{
        class MathClass
        {
        static void Main() 
        {
            double random = 8.94; //defining the variable
           
            Console.WriteLine(Math.Abs(random));  //using the static class to return the absolute value of the variable
            Console.WriteLine(Math.Floor(random)); //using the static class to return the largest integer (LESS THAN) the variable
            Console.WriteLine(Math.Round(Math.Abs(random))); //using the static class to return the variable rounded to the nearest integer

            Console.ReadLine();
        }
        }
        }


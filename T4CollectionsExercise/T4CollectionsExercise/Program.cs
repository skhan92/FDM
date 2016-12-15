using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
 
            while (input.Length > 0)
            {
                Console.Write(input[0] + " : ");
                int count = 0;
                for (int a = 0; a < input.Length; a++)
                {
                    if (input[0] == input[a])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count); 
                input = input.Replace(input[0].ToString(),string.Empty);               
            }
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2CollectionExercises
{
    class Program

    //TASK 1
    //List - Default Collection
    //Dicitonary - KeyValuePairs
    //Hashset - removes duplicate values
    //LinkedList - Allows fast insert and removes
    //Queue - FIFO Collection
    //Stack - LIFO Collection
    //KeyValuePair - Holds a key and an associated pair
    //Tuple - Holds three items together

    {
        static void Main(string[] args)
        {
            string[] array1 =
            {
                "Nana",
                "Ben",
                "Andrew",
                "Daniel",
                "Suleman",
                "Bishan",
                "Mario",
                "Ben",
                "Daniel",
                "Bishan"
            };

            var hash = new HashSet<string>(array1);

            string[] array2 = hash.ToArray();

            Console.WriteLine("Remove duplicates from string: " + string.Join(",", array2));

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> personDictionary =
            //    new Dictionary<int, string>();

            //personDictionary.Add(500, "Nana"); //NOTE KEY HAS TO BE UNIQUE - CANNOT HAVE THE SAME KEY
            //personDictionary.Add(400, "Ben");
            //personDictionary.Add(556, "Andrew");
            //personDictionary.Add(600, "Daniel");
            //personDictionary.Add(450, "Suleman");
            //personDictionary.Add(575, "Bishan");
            //personDictionary.Add(465, "Mario");

            //string value = personDictionary[556];

            //Console.WriteLine(value);
            //Console.ReadLine();

            List<DVD> dvds = new List<DVD>
            {
                new DVD(1, "Shawshank Redemption"),
                new DVD(2, "The Green Mile"),
                new DVD(3, "Gladiator"),
                new DVD(4, "Braveheart"),
                new DVD(5, "Robocop"),
                new DVD(6, "American History X")
            };


            foreach (DVD dvd in dvds)
            {
                Console.WriteLine(dvd.id + " : " + dvd.title);
            }

            //this uses the default comparison - IComparable on the DVD class
            //dvds.Sort();

            //this uses the 3rd method of comparison - using an external class
            dvds.Sort(new DVDPriceComparer());

            foreach (DVD dvd in dvds)
            {
                Console.WriteLine(dvd.id + " : " + dvd.title);
            }

           
            Console.ReadLine();
        }
    }
}

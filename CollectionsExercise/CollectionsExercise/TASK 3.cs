using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Color> colorDictionary =
                new Dictionary<string, Color>();

            colorDictionary.Add("Alice Blue", Color.AliceBlue);
            colorDictionary.Add("Black", Color.Black);
            colorDictionary.Add("Brown", Color.Brown);
            colorDictionary.Add("Crimson", Color.Crimson);
            colorDictionary.Add("Dark Blue", Color.DarkBlue);
            colorDictionary.Add("Dark Green", Color.DarkGreen);
            colorDictionary.Add("Dark Orange", Color.DarkOrange);
            colorDictionary.Add("Fuchsia", Color.Fuchsia);
            colorDictionary.Add("Gold", Color.Gold);
            colorDictionary.Add("Indigo", Color.Indigo);
            colorDictionary.Add("Magenta", Color.Magenta);
            colorDictionary.Add("Sienna", Color.Sienna);
            colorDictionary.Add("White Smoke", Color.WhiteSmoke);

            foreach (KeyValuePair<string, Color> entry in colorDictionary)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlFileWriter writer = new XmlFileWriter(); //Whichever class you use; parent/child, should act in the same way
            writer.Write("Hello");

            Console.ReadLine();
        }
    }
}

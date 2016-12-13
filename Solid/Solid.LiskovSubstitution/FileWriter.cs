using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution
{
    public class FileWriter
    {
        public virtual void Write(string text)
        {
            Console.WriteLine("Writing to file...");
        }
    }

    public class XmlFileWriter : FileWriter
    {
        public override void Write(string text)
        {
            Console.WriteLine("Writing to XML file...");

            //This breaks Liskov as the method now does something that we don't expect it to do
            //Console.WriteLine("Deleting from XML file");
        }
    }
}

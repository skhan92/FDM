using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PensionController controller = new PensionController();
            
            Person person1 = new Person()
            {
            firstName = "John",
            lastName = "Smith",
            dateOfBirth = "28/06/1993"
            };

            Person person2 = new Person()
            {
            firstName = "Jane",
            lastName = "Doe",
            dateOfBirth = "05/01/1950"
            };

            Person person3 = new Person ()
            {
            firstName = "Fred",
            lastName = "Bloggs",
            dateOfBirth = "12/12/1949"
            };

            Person[] people = { person1, person2, person3 };

            controller.HandlePensions(people);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class View
    {
        public void PrintEligible(Person person)
        {
            Console.WriteLine(string.Format("{0} {1} may qualify for a pension this year", person.firstName, person.lastName));
        }

        public void PrintIneligible(Person person)
        {
            Console.WriteLine(string.Format("{0} {1} may not qualify for a pension this year", person.firstName, person.lastName));
        }
    }
}

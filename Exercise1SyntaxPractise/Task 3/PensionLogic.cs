using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class PensionLogic
    {
        public bool IsPensionable(Person person, string year)
        {
          int yearOfBirth = Convert.ToInt32(person.dateOfBirth.Substring(person.dateOfBirth.Length - 4));

          int yearOfRetirement = Convert.ToInt32(year);

          int age = yearOfRetirement - yearOfBirth; 

          if (age >= 65)
          {
              return true;
          }
          else
          {
              return false;
          }
        }
    }
}

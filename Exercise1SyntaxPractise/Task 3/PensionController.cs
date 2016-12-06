using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class PensionController
    {
        public void HandlePensions(Person[] people)
        {
            PensionLogic pensionLogic = new PensionLogic();

            View view = new View();

            foreach (Person person in people)
            {
                bool isPensionable = pensionLogic.IsPensionable(person, "2014");

                if (isPensionable == true)
                {
                    view.PrintEligible(person);
                }
                else
                {
                    view.PrintIneligible(person);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class GradeCalculator
    {
        public string getClassification(double mark)
        {
            if (mark < 75)
            {
                return "fail";
            }
            else if (mark >=75 && mark < 80)
            {
                return "pass";
            }
            else if (mark >=80 && mark < 90)
            {
                return "merit";
            }
            return "distinction";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillars.Encapsulation
{
    class Student
    {
        //ENCAPSULATION - grouping RELEVANT stuff together//

        public string name { get; set; }
        public int id { get; set; }
        public string gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public decimal debt { get; set; }
        //these below are not relevant for a student
        //public int StudentUnionPhoneNumber { get; set; }
        //public DateTime TermDates { get; set; }

        //Variables encapsulate pieces of data
        //Methods encapsulate logic
        //Objects/classes encapsulate variables and methods
        //Projects encapsulate classes
        //Solutions encapsulate projects
    }
}
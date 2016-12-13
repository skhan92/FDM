using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibility
{
    public class Student
    {
        //SRP each class should be responsible for one thing

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int studentNumber { get; set; }
        public double debt { get; set; }

        //These are not relevant to a student and therefore breaks single responsibility because the class no longer has one responsibility
        //public int studentUnionPhoneNumber { get; set; }
        //public DateTime happyHour { get; set; }

        //Difficult one - fracturing responsibility, this student class would hold student data and behaviour..
        //public void GoToLecture()
        //{
        //}

        //This one again - fractures responsibility
        //public void SignUpToNewCourse(string courseName)
        //{
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillars.Inheritance
{
    //This is inheritance using abstract classes

    abstract class User
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    class Buyer : User
    {
    
    }

    class Seller : User
    {

    }

    class Admin : User
    {
        public string passord { get; set; }
    }
}

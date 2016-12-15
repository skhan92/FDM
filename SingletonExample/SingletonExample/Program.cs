using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton mySingleton = Singleton.Instance;
            mySingleton.DoSomething();

            Singleton mySingleton1 = Singleton.Instance;
        }
    }
}

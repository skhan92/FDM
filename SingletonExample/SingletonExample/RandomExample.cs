using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class RandomExample
    {
        Singleton mySingleton2 = Singleton.Instance;
        public RandomExample()
        {
            mySingleton2.DoSomething();
        }
        
    }
}
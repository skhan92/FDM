using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{

    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {

        }
  
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Hello there!");
            Console.ReadLine();
        }
    }
}

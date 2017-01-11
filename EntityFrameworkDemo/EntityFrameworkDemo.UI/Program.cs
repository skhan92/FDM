using EntityFrameworkDemo.DatabaseFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.UI 
{
    class Program
    {
        static void Main(string[] args)
        {
            EFDemoDatabaseFirstEntities context = new EFDemoDatabaseFirstEntities();

            foreach (broker broker in context.brokers)
            {
                Console.WriteLine(broker.name);
            }

            Console.ReadLine();
        }
    }
}

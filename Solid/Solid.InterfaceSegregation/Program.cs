using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            LazyWorker worker1 = new LazyWorker();
            EfficientWorker worker2 = new EfficientWorker();
            RobotWorker worker3 = new RobotWorker();

            worker1.Eat();
            worker1.Work();

            worker2.Eat();
            worker2.Work();

            worker3.Work();
        }
    }
}

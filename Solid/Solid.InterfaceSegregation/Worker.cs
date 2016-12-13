using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation
{
    //public interface Worker //Interface is essentially abstract so it helps w dependency inverison and the other principles
    //{
    //    void Work();
    //    void Eat();
    //}

    //BELOW IS INTERFACE SEGREGATION
    public interface Worker
    {
        void Work();
    }
   
    public interface Eater
    {
        void Eat();
    }


    public class EfficientWorker : Worker, Eater
    {

        public void Work()
        {
            Console.WriteLine("I work as much as I can");
        }

        public void Eat()
        {
            Console.WriteLine("I only eat when I have to");
        }
    }

    public class LazyWorker : Worker, Eater
    {

        public void Work()
        {
            Console.WriteLine("I only work when I am being watched");
        }

        public void Eat()
        {
            Console.WriteLine("I eat whenever I feel like it");
        }
    }

    public class RobotWorker : Worker //Issue: doesn't use the same functions as workers, no need to eat..
    {
        public void Work()
        {
            Console.WriteLine("I work 24/7");
        }

        //BELOW IS INTERFACE POLLUTION, USED INTERFACE SEG TO DEAL W THIS
        //public void Eat()
        //{
        //    Console.WriteLine("I don't eat");
        //}
    }
}

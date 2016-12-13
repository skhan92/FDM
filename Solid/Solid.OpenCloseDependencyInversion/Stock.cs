using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenCloseDependencyInversion
{
    public abstract class Stock //using an abstract class is half of dependency inversion
    {
        public int value { get; set; }
    }

    public class Share : Stock
    {

    }

    public class Bond : Stock
    {

    }

    public class ForeignEx : Stock
    {

    }
    //RANDOM ADJUSTMENTS BELOW DUE TO DEPDENDENCY INVERSION
    public class Gilt : Stock
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenCloseDependencyInversion
{
    class TradeController
    {
        public void TradeShare(Share share)
        {
            //DoStuff
        }

        public void TradeBonds(Bond bond)
        {
            //DoStuff
        }

        //This breaks OpenClose. Class was finished, by adjusting it, OpenClose is broken. 
        //Chances of adjusting a finished class and then breaking it are high. 
        //Dependency Inversion is the way out of this!
        public void TradeFex(ForeignEx Fx)
        {
            //DoStuff
        }
    }
    //DEPENDENCY INVERSION FOR GENERAL ADJUSTMENTS
    public class DependencyInversionTradeController
    {
        public void Trade(Stock stock)
        {
            //DoStuff
        }
    }
}

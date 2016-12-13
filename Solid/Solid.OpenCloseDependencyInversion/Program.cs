using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenCloseDependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Best way of making it OpenClose is Dependency Inversion
            //i.e. If you do dependency inversion, very likely, openclose will take care of itself

            TradeController tradeController = new TradeController();
            tradeController.TradeBonds(new Bond());
            tradeController.TradeShare(new Share());

            DependencyInversionTradeController dptc = new DependencyInversionTradeController();
            dptc.Trade(new Bond());
            dptc.Trade(new ForeignEx());
            dptc.Trade(new Share());
        }
    }
}

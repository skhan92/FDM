using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace FDMGift.Domain
{
    public class Class1
    {
        private static readonly ILog logger = LogManager.GetLogger("Class1.cs");
    }

   

}
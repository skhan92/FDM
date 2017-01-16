using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class Charities
    {
        public int id { get; set; }
        public string charityName { get; set; }
        public int targetAmount { get; set; }
    }
}

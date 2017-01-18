using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class Charities
    {
        public int id { get; set; }
        [DisplayName("Name")]
        public string charityName { get; set; }
        [DisplayName("Target Amount")]
        public int targetAmount { get; set; }
    }
}

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
        public virtual int id { get; set; }
        [DisplayName("Name")]
        public virtual string charityName { get; set; }
        [DisplayName("Target Amount")]
        public virtual int targetAmount { get; set; }
    }
}

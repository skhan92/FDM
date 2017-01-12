using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Basket
    {
        [Key]
        public int basketId { get; set; }
        public int userId { get; set; }
        public int charityId { get; set; }
        public int amountDonated { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONEDSO.EntityFramework
{
    public class Product
    {
        public virtual int productid { get; set; }
        [DisplayName("Product Name")]
        public virtual string productName { get; set; }
        [DisplayName("Price")]
        public virtual int price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONEDSO.EntityFramework
{
    public class BasketRepository
    {
        public EFramework _context;

        public BasketRepository(EFramework context)
        {
            _context = context;
        }

        //public virtual void AddProduct(Product productName)
        //{
        //    _context.basket.Add(Product.productName);
        //    _context.SaveChanges();
        //}
    }
}

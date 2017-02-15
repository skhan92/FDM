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

        public virtual void AddProduct(Product productToAdd)
        {
            //_context.basket.Add(productToAdd);
            //_context.SaveChanges();
        }
    }
}

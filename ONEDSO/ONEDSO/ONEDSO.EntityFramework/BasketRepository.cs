using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONEDSO.EntityFramework
{
    public class BasketRepository
    {
        public EntityFramework _context;

        public BasketRepository(EntityFramework context)
        {
            _context = context;
        }

        public List<Product> GetAllProucts()
        {
            return _context.product.ToList();
        }

        public virtual void addProducts(Basket productsToAdd)
        {
            _context.basket.Add(productsToAdd);
            _context.SaveChanges();
        }
    }
}

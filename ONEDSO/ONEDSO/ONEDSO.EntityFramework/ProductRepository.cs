using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONEDSO.EntityFramework
{
    public class ProductRepository
    {
        public EFramework _context;
        
        public ProductRepository(EFramework context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.product.ToList();
        }
    }
}

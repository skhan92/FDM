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

        //    public void AddProductToBasket(Basket basket, Product product)
        //    {
        //        if (basketrepo.GetAllBasket().Contains)
        //}
    }
}

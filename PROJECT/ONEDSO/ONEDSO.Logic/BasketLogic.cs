//using ONEDSO.EntityFramework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ONEDSO.Logic
//{
//    public class BasketLogic
//    {
//        BasketRepository basketrepo;

//        public BasketLogic(BasketRepository basketrepository)
//        {
//            basketrepo = basketrepository;
//        }

//        public void AddProductToBasket(Basket basket, Product product)
//        {
//            if (basketrepo.GetAllBasket().Contains(basket))
//            {
//                throw EntityAlreadyExistsException();
//            }
//            else
//            {
//                basket.productsInBasket.Add(product);
//            }
//        }

//        private Exception EntityAlreadyExistsException()
//        {
//            throw new NotImplementedException();
//        }
//    }

    //public class BasketLogic : IBasketLogic
    //{
    //    BasketRepository br;
    //    EFramework _EF;

    //    public BasketLogic(EFramework EF)
    //    {
    //        _EF = EF;
    //    }
    //}
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Checkout
    {

        public double calculatePrice(Basket myBasket)
        {
            int discount = 0;
            double price = 0.0;
            for (int i = 0; i < myBasket.getBooksInBasket().Count; i++)
            {
                price = price + myBasket.getBooksInBasket()[i].price;
            }
            discount = myBasket.getBooksInBasket().Count / 3;
            price = price * (1 - discount / 100.00);
            return price;
        }
    }
}

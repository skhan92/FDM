using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class BasketRepository
    {
        public EntityFramework _context;

        public BasketRepository(EntityFramework context)
        {
            _context = context;
        }

        public List<Basket> GetBasket()
        {
            return _context.basket.ToList();
        }

        public void addBasket(Basket BasketToAdd) //Adding a Basket to the database
        {
            //Adding a Basket to the database
            _context.basket.Add(BasketToAdd);
            _context.SaveChanges();
        }

        public void updateBasket(int IdToChange, string WhatToChange, int changeTo) //Updating the details of an existing basket
        {
            string amountDonated = "amountDonated";


            //Update database
            var query = from b in _context.basket
                        where b.basketId == IdToChange
                        select b;

            foreach (var basket in query)
            {
                if (WhatToChange == amountDonated)
                {
                    basket.amountDonated = changeTo;
                }
            }
            _context.SaveChanges();
        }

        public void removeBasket(Basket BasketToUpdate, int IdToRemove) //Removing an exisiting Basket by ID
        {
            //Remove a basket from the database
            foreach (Basket basket in _context.basket)
            {
                if (basket.basketId == IdToRemove)
                {
                    _context.basket.Remove(basket);
                }
            }
            _context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class CharitiesRepository
    {
        public EntityFramework _context;

        public CharitiesRepository(EntityFramework context)
        {
            _context = context;
        }

        public List<Charities> GetAllCharities()
        {
            return _context.charities.ToList();
        }

        public void addCharities(Charities CharitiesToAdd) //Adding a charity to the database
        {
            //Adding a charity to the database
            _context.charities.Add(CharitiesToAdd);
            _context.SaveChanges();
        }

        public void updateCharities(int IdToChange, string WhatToChange, int changeTo) //Updating the targetAmount for a charity
        {
            string targetAmount = "targetAmount";


            //Update database
            var query = from b in _context.charities
                        where b.id == IdToChange
                        select b;

            foreach (var charities in query)
            {
                if (WhatToChange == targetAmount)
                {
                    charities.targetAmount = changeTo;
                }
            }
            _context.SaveChanges();
        }

        public void removeCharities(Charities CharitiesToUpdate, int IdToRemove) //Removing an exisiting charity by ID
        {
            //Remove a charity from the database
            foreach (Charities charities in _context.charities)
            {
                if (charities.id == IdToRemove)
                {
                    _context.charities.Remove(charities);
                }
            }
            _context.SaveChanges();
        }
    }
}

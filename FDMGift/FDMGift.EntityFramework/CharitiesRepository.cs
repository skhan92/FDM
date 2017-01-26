using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class CharitiesRepository
    {
        public EFramework _context;

        public CharitiesRepository(EFramework context)
        {
            _context = context;
        }

        public List<Charities> GetAllCharities()
        {
            return _context.charities.ToList();
        }

        public virtual bool checkCharityExists(string NameOfCharityToCheck)
        {
            var query = from b in _context.charities
                        where b.charityName == NameOfCharityToCheck
                        select b;

            foreach (var user in query)
            {
                if (NameOfCharityToCheck == user.charityName)
                {
                    return true;
                }
            }
            return false;
        }

        public virtual void addCharities(Charities CharitiesToAdd) //Adding a charity to the database
        {
            //Adding a charity to the database
            _context.charities.Add(CharitiesToAdd);
            _context.SaveChanges();
        }

        public void updateCharities(int IdToChange, string WhatToChange, int changeTo) //Updating the targetAmount for a charity
        {
            string newTargetAmount = "newTargetAmount";


            //Update database
            var query = from b in _context.charities
                        where b.id == IdToChange
                        select b;

            foreach (var charities in query)
            {
                if (WhatToChange == newTargetAmount)
                {
                    charities.targetAmount = changeTo;
                }
            }
            _context.SaveChanges();
        }

        public void removeCharities(int IdToRemove) //Removing an exisiting charity by ID
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

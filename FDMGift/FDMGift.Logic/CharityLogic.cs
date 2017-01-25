using FDMGift.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.Logic
{
    public interface ICharityLogic
    {
        void RegisterCharity(Charities charityToAdd);
    }

    public class CharityLogic : ICharityLogic
    {
        CharitiesRepository cr;
        EFramework _EF;
        public CharityLogic(EFramework EF)
        {
            _EF = EF;
            cr = new CharitiesRepository(_EF);
        }

        public void RegisterCharity(Charities charityToAdd)
        {
            if (cr.checkCharityExists(charityToAdd.charityName) == false)
            {
               cr.addCharities(charityToAdd);  
            }
        }
    }
}

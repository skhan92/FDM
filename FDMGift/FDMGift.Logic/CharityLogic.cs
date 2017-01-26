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
        bool RegisterCharity(Charities charityToAdd);
    }

    public class CharityLogic : ICharityLogic
    {
        CharitiesRepository cr;
        EFramework _EF;

        public CharityLogic(EFramework EF)
        {
            _EF = EF;
        }

        public CharityLogic(CharitiesRepository CharitiesRepository)
        {
            cr = CharitiesRepository;
        }

        public bool RegisterCharity(Charities charityToAdd)
        {
            if (cr.checkCharityExists(charityToAdd.charityName) == true)
            {
                return true; 
            }
            cr.addCharities(charityToAdd);
            return false;
        }
    }
}

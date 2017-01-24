using FDMGift.Logic;
using FDMGift.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.WPF.ViewModels
{
    public class AddCharity
    {
        EFramework db = new EFramework();

        public void AddCharityToDB(Charities charityToAdd)
        {
            CharityLogic clogic = new CharityLogic(db);
            //clogic.RegisterCharity(charityName, targetAmount);
        }
    }
}

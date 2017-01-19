using FDMGift.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.Logic
{
    public interface IUserLogic
    {
        bool RegisterUser(Users userToAdd);
    }

    public class UserLogic : IUserLogic
    {
        EFramework _EF;
        public UserLogic(EFramework EF)
        {
            _EF = EF;
        }

        public bool RegisterUser(Users userToAdd)
        {
            UserRepository ur = new UserRepository(_EF);
            if (ur.checkUserExists(userToAdd.email) == true)
            {
                return true;
            }
            ur.addUsers(userToAdd);
            return false;
        }
    }
}

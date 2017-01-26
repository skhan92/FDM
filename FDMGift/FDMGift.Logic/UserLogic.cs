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
        UserRepository ur;

        public UserLogic(EFramework EF)
        {
            _EF = EF;
            ur = new UserRepository(EF);
        }

        public UserLogic(UserRepository UserRepository)
        {
            ur = UserRepository;
        }

        public bool RegisterUser(Users userToAdd)
        {
            if (ur.checkUserExists(userToAdd.email) == true)
            {
                return true;
            }
            ur.addUsers(userToAdd);
            return false;
        }
    }
}

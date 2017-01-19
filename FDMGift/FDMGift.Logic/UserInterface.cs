using FDMGift.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.Logic
{
    public interface IUser
    {
        List<Users> GetAllUsers();
        bool checkUserDetails(string EmailOfUserToCheck, string PasswordToCheck);
        void addUsers(Users UsersToAdd);
    }

    public class User
    {
        EFramework _context;

        public User(EFramework context)
        {
            _context = context;
        }

         public List<Users> GetAllUsers()
        {
            return _context.users.ToList();
        }

         public bool checkUserDetails(string EmailOfUserToCheck, string PasswordToCheck)
         {
             var query = from b in _context.users
                         where b.email == EmailOfUserToCheck && b.password == PasswordToCheck
                         select b;

             foreach (var user in query)
             {
                 if (EmailOfUserToCheck == user.email && PasswordToCheck == user.password)
                 {
                     return true;
                 }
             }
             return false;
         }

         public void addUsers(Users UsersToAdd) //Adding a user to the database
         {
             //Adding a user to the database
             _context.users.Add(UsersToAdd);
             _context.SaveChanges();
         }
    }
}

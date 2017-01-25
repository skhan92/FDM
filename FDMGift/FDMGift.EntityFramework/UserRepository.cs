using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class UserRepository
    {
        public EFramework _context;

        public UserRepository(EFramework context)
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

        public bool checkUserExists(string EmailOfUserToCheck)
        {
            var query = from b in _context.users
                        where b.email == EmailOfUserToCheck
                        select b;

            foreach (var user in query)
            {
                if (EmailOfUserToCheck == user.email)
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

        public void updateUser(string EmailToChange, string WhatToChange, string changeTo) //Updating the details of an existing user
        {
            string fullName = "fullName";
            string email = "email";
            string password = "password";


            //Update database
            var query = from b in _context.users
                        where b.email == EmailToChange
                        select b;

            foreach (var users in query)
            {
                if (WhatToChange == fullName)
                {
                    users.fullName = changeTo;
                }
                if (WhatToChange == password)
                {
                    users.password = changeTo;
                }
            }
            _context.SaveChanges();
        }

        public void removeUsers(int IdToRemove) //Removing an exisiting user by ID
        {
            //Remove a user from the database
            foreach (Users users in _context.users)
            {
                if (users.id == IdToRemove)
                {
                    _context.users.Remove(users);
                }
            }
            _context.SaveChanges();
        }
    }
}

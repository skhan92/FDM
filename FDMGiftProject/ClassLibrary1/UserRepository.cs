using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class UserRepository
    {
        public EntityFramework _context;

        public UserRepository(EntityFramework context)
        {
            _context = context;
        }

        public List<Users> GetAllUsers()
        {
            return _context.users.ToList();
        }

        public void addUsers(Users UsersToAdd) //Adding a user to the database
        {
            //Adding a user to the database
            _context.users.Add(UsersToAdd);
            _context.SaveChanges();
        }

        public void updateUsers(int IdToChange, string WhatToChange, string changeTo) //Updating the details of an existing user
        {
            string fullName = "fullName";
            string email = "email";
            string password = "password";


            //Update database
            var query = from b in _context.users
                        where b.id == IdToChange
                        select b;

            foreach (var users in query)
            {
                if (WhatToChange == fullName)
                {
                   users.fullName = changeTo;
                }
                if (WhatToChange == email)
                {
                   users.email = changeTo;
                }
                if (WhatToChange == password)
                {
                    users.password = changeTo;
                }
            }
            _context.SaveChanges();
        } 

        public void removeUsers(Users UsersToUpdate, int IdToRemove) //Removing an exisiting user by ID
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

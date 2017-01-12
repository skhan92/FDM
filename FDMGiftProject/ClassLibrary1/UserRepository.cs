using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
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

        public void addUsers (Users UsersToAdd)
        {
            //Adding a user to the database
            _context.users.Add(UsersToAdd);
            _context.SaveChanges();
        }

        public void updateUsers (Users UsersToUpdate, string WhatToChange)
        {
            //Update database
           Users u = _context.users.Find(UsersToUpdate.fullName);

           var query = from b in context.users
                       where b.id == 1
                       select b;

           foreach (var users in query)
           {
               Console.WriteLine(users.fullName);
           }

            if(u.fullName == name)
            {
                u.fullName = nwName;
            }
            
            _context.SaveChanges();   
        }


    }
}

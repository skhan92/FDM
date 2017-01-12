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

        public void addUsers (Users UsersToAdd, string fullName, string eMail, string passWord)
        {
            //Adding a user to the database
            _context.users.Add(UsersToAdd);
            _context.SaveChanges();
        }

        //public void updateUsers (Users UsersToUpdate, int IdToChange, string WhatToChange)
        //{
        //    //Update database
        //   var query = from b in _context.users
        //               where b.id == IdToChange
        //               select b;

        //   foreach (var users in query)
        //   {
        //       Console.WriteLine(users.fullName);
        //   }

        //    if( == )
        //    {
        //        u.fullName = nwName;
        //    }
            
        //    _context.SaveChanges();   
        //}


    }
}

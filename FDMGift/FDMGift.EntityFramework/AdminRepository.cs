using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class AdminRepository
    {
        public EFramework _context;

        public AdminRepository(EFramework context)
        {
            _context = context;
        }

        public List<Admins> GetAllAdmins()
        {
            return _context.admins.ToList();
        }

        public bool checkAdminDetails(string EmailOfAdminToCheck, string AdminPasswordToCheck)
        {
            var query = from b in _context.admins
                        where b.email == EmailOfAdminToCheck && b.password == AdminPasswordToCheck
                        select b;

            foreach (var user in query)
            {
                if (EmailOfAdminToCheck == user.email && AdminPasswordToCheck == user.password)
                {
                    return true;
                }
            }
            return false;
        }


        public void updateAdmins(int IdToChange, string WhatToChange, string changeTo) //Updating the details of an existing Admin
        {
            string fullName = "fullName";
            string email = "email";
            string password = "password";


            //Update database
            var query = from b in _context.admins
                        where b.id == IdToChange
                        select b;

            foreach (var admins in query)
            {
                if (WhatToChange == fullName)
                {
                    admins.fullName = changeTo;
                }
                if (WhatToChange == email)
                {
                    admins.email = changeTo;
                }
                if (WhatToChange == password)
                {
                    admins.password = changeTo;
                }
            }
            _context.SaveChanges();
        }
    }
}

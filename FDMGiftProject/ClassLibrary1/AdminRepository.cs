using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AdminRepository
    {
        public EntityFramework _context;

        public AdminRepository(EntityFramework context)
        {
            _context = context;
        }

        public List<Admins> GetAllAdmins()
        {
            return _context.admins.ToList();
        }

        public void updateAdmins(int IdToChange, string WhatToChange, string changeTo)
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

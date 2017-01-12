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
    }
}

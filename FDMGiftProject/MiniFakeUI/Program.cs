using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFakeUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Returns all the users full names
            EntityFramework context = new EntityFramework();

            //Adding a user to the database
            //Users newUsers = new Users() { id = 9, fullName = "Daniel Kloss", email = "dankloss@fdmgroup.com", password = "danftw" };
            //context.users.Add(newUsers);
            //context.SaveChanges();
 
            //Update database
            //Users userToUpdate = context.users.Find(//WHATEVER ID TO REMOVE IN RELATION TO TABLE);
            //userToUpdate.fullName = "Mugiwara no Luffy";
            //context.SaveChanges();

            //Remove a user from the database
            //foreach (Users users in context.users)
            //{
            //    if (users.id == //WHATEVER ID TO REMOVE IN RELATION TO TABLE)
            //    {
            //        context.users.Remove(users);
            //    }
            //}
            //context.SaveChanges();

            //Using Linq statement
            var query = from b in context.users
                        where b.id == 1
                        select b;

            foreach (var users in query)
            {
                Console.WriteLine(users.fullName);
            }

            Console.ReadLine();

            //BELOW IS FOR ADDING, UPDATING, REMOVING
            //foreach (Users users in context.users)
            //{
            //    Console.WriteLine(users.fullName);
            //}
            //    Console.ReadLine();
        }
    }
}

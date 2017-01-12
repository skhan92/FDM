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
        {//THIS IS CODE FOR ADDING, UPDATING AND REMOVING USERS FROM THE DATABASE
            //Returns all the users full names
            EntityFramework context = new EntityFramework();



            //USERS

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
            //var query = from b in context.users
            //            where b.id == 1
            //            select b;

            //foreach (var users in query)
            //{
            //    Console.WriteLine(users.fullName);
            //}

            //Console.ReadLine();

            //BELOW IS FOR ADDING, UPDATING, REMOVING
            //foreach (Users users in context.users)
            //{
            //    Console.WriteLine(users.fullName);
            //}
            //    Console.ReadLine();





            //CHARITIES


            //Adding a CHARITY to the database
            //Charities newCharities = new Charities() { id = 4, charityName = "Save the Children", targetAmount = 200 };
            //context.charities.Add(newCharities);
            //context.SaveChanges();

            //Update database
            //Charities charitiesToUpdate = context.charities.Find(4);
            //charitiesToUpdate.charityName = "Helping Hands";
            //context.SaveChanges();

            //Remove a charity from the database
            //foreach (Charities charities in context.charities)
            //{
            //    if (charities.id == 5)
            //    {
            //        context.charities.Remove(charities);
            //    }
            //}
            //context.SaveChanges();

            //Using Linq statement
            //var query = from b in context.charities
            //            where b.id == 1
            //            select b;

            //foreach (var charities in query)
            //{
            //    Console.WriteLine(charities.charityName);
            //}
            //Console.ReadLine();

            //BELOW IS FOR ADDING, UPDATING, REMOVING
            //foreach (Charities charities in context.charities)
            //{
            //    Console.WriteLine(charities.charityName);
            //}
            //    Console.ReadLine();




            //ADMINS
            //Update Admins database
            //Admins adminsToUpdate = context.admins.Find(2);
            //adminsToUpdate.fullName = "Helping Hands";
            //context.SaveChanges();


            //Using Linq statement
            //var query = from b in context.charities
            //            where b.id == 1
            //            select b;

            //foreach (var charities in query)
            //{
            //    Console.WriteLine(charities.charityName);
            //}
            //Console.ReadLine();

            //BELOW IS FOR UPDATING
            //foreach (Charities charities in context.charities)
            //{
            //    Console.WriteLine(charities.charityName);
            //}
            //    Console.ReadLine();
        }
    }
}

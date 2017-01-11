using EntitiyFrameworkDemo.CodeFirst;
using EntityFrameworkDemo.DatabaseFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.UI 
{
    class Program
    {
        static void Main(string[] args)
        {
            //THIS IS FOR DATABASE FIRST
            //EFDemoDatabaseFirstEntities context = new EFDemoDatabaseFirstEntities();

            //foreach (broker broker in context.brokers)
            //{
            //    Console.WriteLine(broker.name);
            //}

            //THIS IS FOR CODE FIRST
            CodeFirstModel context = new CodeFirstModel();

            //Adding something to the database
            //Broker newBroker = new Broker() { name = "Bishan", companyId = 1 };
            //context.brokers.Add(newBroker);
            //context.SaveChanges();  //IN CODE HAVE ONLY ONE SAVE CHANGES SO ONLY GOING THROUGH DATABASE ONCE
            //Finished code to add broker

            //Updating Broker
            //Broker brokerToUpdate = context.brokers.Find(2);
            //brokerToUpdate.name = "Luffy";
            //context.SaveChanges();
            //Finishing code to update broker

            //Removing Broker
            //foreach (Broker broker in context.brokers)
            //{
            //    if (broker.id == 3)
            //    {
            //        context.brokers.Remove(broker);
            //    }
            //}
            //context.SaveChanges(); //need to find a better way, this one is hardcoded.
            //Finishing code to remove broker
            //foreach (Broker broker in context.brokers)
            //{
            //    Console.WriteLine(broker.name);
            //} 

            //Using Linq statement
            var query = from b in context.brokers
                        where b.companyId == 1
                        select b;

            foreach (var broker in query)
            {
                Console.WriteLine(broker.name);
            }
            //Finishing using Linq. Returns broker names for whom the company id is 1.

            Console.ReadLine();
        }
    }
}

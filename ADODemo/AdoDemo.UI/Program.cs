using ADODemo.Connected;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDemo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=TRNLON11508;Initial Catalog=DemoDatabase;Integrated Security=True";

            IBrokerRepository _brokerRepo = new MicrosoftSqlServerBrokerRepository(connectionString);

            //_brokerRepo.AddNewBroker(new Broker() { id = 5, firstName = "Pika", lastName = "Chu" });
            //_brokerRepo.UpdateBroker(4, new Broker() { firstName = "Snoopy", lastName = "The Dog" });
            //_brokerRepo.RemoveBroker(5);

            IBrokerRepository _brokerRepoDisconnected = new MicrosoftSqlServerDisconnected(connectionString); //Runs the Disconnected method

            _brokerRepoDisconnected.UpdateBroker(5, new Broker() { firstName = "Ichigo", lastName = "Kurosaki" });

            List<Broker> allBrokers = _brokerRepo.GetAllBrokers();

            foreach (Broker broker in allBrokers)
            {
                Console.WriteLine(broker.firstName + " " + broker.lastName);
            }
            
            Console.ReadLine();
        }
    }
}

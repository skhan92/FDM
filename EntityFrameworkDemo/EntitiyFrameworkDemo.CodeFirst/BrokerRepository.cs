using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo.CodeFirst
{
    public class BrokerRepository
    {
        CodeFirstModel _context; //take the object and save it

        public BrokerRepository(CodeFirstModel context) 
        {
            _context = context;
        }

        public virtual List<Broker> GetAllBrokers() 
        {
            //CodeFirstModel context = new CodeFirstModel(); LINE BECOMES IRRELEVANT AS NEW CONTEXT IS NOT NEEDED. NEGATES THE DEPENDENCY INJECTION 
            return _context.brokers.ToList(); //Use _context as that is what I was given to use. No need to make a new one.
        }
    }
}

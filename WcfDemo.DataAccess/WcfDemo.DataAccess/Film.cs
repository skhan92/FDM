using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfDemo.DataAccess
{
    //[DataContract] Allow for serialisation as do the datamembers below 
    public class Film
    {
        //[DataMember]
        public int id { get; set; }
        //[DataMember]
        public string name { get; set; }
    }
}

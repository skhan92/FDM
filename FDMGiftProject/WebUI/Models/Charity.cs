using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class EntityFramework : DbContext
    {
        public DbSet<Charity> charities { get; set; }
    }

    public class Charity
    {
        public int id { get; set; }

        [DisplayName("Charity")]
        public string charityName { get; set; }

        [DisplayName("Target Amount")]
        public int targetAmount { get; set; }
    }
}
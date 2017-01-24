using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPAdvancedDemo.Models
{
    //FAKE DATABASE JUST TO MAKE IT QUICK
    public class BookDbContext : DbContext
    {
        public DbSet<Book> books { get; set; }
    }

    public class Book
    {
        public int id { get; set; }

        [DisplayName("Title")]
        public string title { get; set; }

        [DisplayName("Author")]
        public string author { get; set; }

        [DisplayName("Price")]
        public double price { get; set; }
    }
}
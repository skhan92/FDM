namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityFramework : DbContext
    {
        public EntityFramework()
            : base("name=EntityFrameworkDatabase")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        DbSet<Users> users { get; set; }
        DbSet<Admins> admins { get; set; }
        DbSet<Charities> charities { get; set; }
        DbSet<Basket> basket { get; set; }
    }
}

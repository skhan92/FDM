namespace FDMGift.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFramework : DbContext
    {
        public EFramework()
            : base("name=EntityFramework")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Users> users { get; set; }
        public DbSet<Admins> admins { get; set; }
        public DbSet<Charities> charities { get; set; }
        public DbSet<Basket> basket { get; set; }

    }
}

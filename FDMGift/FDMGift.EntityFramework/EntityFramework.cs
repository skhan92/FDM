namespace FDMGift.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityFramework : DbContext
    {
        public EntityFramework()
            : base("name=EntityFramework")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Users> users { get; set; }
        public DbSet<Admins> admins { get; set; }
        public DbSet<Charities> charities { get; set; }
        public DbSet<Basket> basket { get; set; }

    }
}
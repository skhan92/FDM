namespace ONEDSO.EntityFramework
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

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Product> product { get; set; }
        public virtual DbSet<Basket> basket { get; set; }
    }
}

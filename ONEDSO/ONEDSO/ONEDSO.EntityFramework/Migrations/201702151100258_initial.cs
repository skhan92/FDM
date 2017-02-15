namespace ONEDSO.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        basketId = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                    })
                .PrimaryKey(t => t.basketId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productid = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Baskets");
        }
    }
}

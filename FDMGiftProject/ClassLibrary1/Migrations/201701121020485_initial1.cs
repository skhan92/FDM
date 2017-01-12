namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        basketId = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        charityId = c.Int(nullable: false),
                        amountDonated = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.basketId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Baskets");
        }
    }
}

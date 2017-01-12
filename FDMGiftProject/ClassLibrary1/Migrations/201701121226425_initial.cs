namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fullName = c.String(),
                        email = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
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
            
            CreateTable(
                "dbo.Charities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        charityName = c.String(),
                        targetAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fullName = c.String(),
                        email = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Charities");
            DropTable("dbo.Baskets");
            DropTable("dbo.Admins");
        }
    }
}

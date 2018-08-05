namespace BankingApplicationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USER_DETAILS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ACCOUNT_NUMBER = c.Long(nullable: false),
                        ACCOUNT_TYPE = c.String(nullable: false),
                        ACCOUNT_HOLDER_NAME = c.String(nullable: false),
                        ACCOUNT_BALANCE = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.ACCOUNT_NUMBER, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.USER_DETAILS", new[] { "ACCOUNT_NUMBER" });
            DropTable("dbo.USER_DETAILS");
        }
    }
}

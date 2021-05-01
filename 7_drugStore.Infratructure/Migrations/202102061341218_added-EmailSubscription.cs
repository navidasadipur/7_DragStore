namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedEmailSubscription : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmailSubscriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmailSubscriptions");
        }
    }
}

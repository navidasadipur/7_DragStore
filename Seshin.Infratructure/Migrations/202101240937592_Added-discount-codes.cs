namespace SpadStore.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addeddiscountcodes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiscountCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DiscountCodeStr = c.String(),
                        ActivationStartDate = c.DateTime(nullable: false),
                        ActivationEndDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Value = c.Long(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiscountCodes", "CustomerId", "dbo.Customers");
            DropIndex("dbo.DiscountCodes", new[] { "CustomerId" });
            DropTable("dbo.DiscountCodes");
        }
    }
}

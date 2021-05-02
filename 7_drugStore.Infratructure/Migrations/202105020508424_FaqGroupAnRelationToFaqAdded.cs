namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FaqGroupAnRelationToFaqAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FaqGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 600),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Faqs", "FaqGroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Faqs", "FaqGroupId");
            AddForeignKey("dbo.Faqs", "FaqGroupId", "dbo.FaqGroups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faqs", "FaqGroupId", "dbo.FaqGroups");
            DropIndex("dbo.Faqs", new[] { "FaqGroupId" });
            DropColumn("dbo.Faqs", "FaqGroupId");
            DropTable("dbo.FaqGroups");
        }
    }
}

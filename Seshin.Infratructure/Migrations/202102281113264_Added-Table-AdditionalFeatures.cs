namespace Seshin.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTableAdditionalFeatures : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalFeatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        ProductId = c.Int(nullable: false),
                        AditionalFeatureType = c.Int(nullable: false),
                        Image = c.String(),
                        Link = c.String(),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdditionalFeatures", "ProductId", "dbo.Products");
            DropIndex("dbo.AdditionalFeatures", new[] { "ProductId" });
            DropTable("dbo.AdditionalFeatures");
        }
    }
}

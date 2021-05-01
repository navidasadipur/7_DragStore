namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTablesProductColorProductPerfumeSimilarProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SimilarProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SimilarProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.PerfumeNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        ProductId = c.Int(nullable: false),
                        PerfumeNoteType = c.Int(nullable: false),
                        Image = c.String(),
                        Link = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Image = c.String(),
                        Link = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductColors", "ProductId", "dbo.Products");
            DropForeignKey("dbo.PerfumeNotes", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SimilarProducts", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductColors", new[] { "ProductId" });
            DropIndex("dbo.PerfumeNotes", new[] { "ProductId" });
            DropIndex("dbo.SimilarProducts", new[] { "ProductId" });
            DropTable("dbo.ProductColors");
            DropTable("dbo.PerfumeNotes");
            DropTable("dbo.SimilarProducts");
        }
    }
}

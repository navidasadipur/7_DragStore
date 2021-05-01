namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productCommentsModelChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductComments", "ParentId", "dbo.ProductComments");
            DropIndex("dbo.ProductComments", new[] { "ParentId" });
            CreateTable(
                "dbo.OurTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        Image = c.String(),
                        FaceBookLink = c.String(),
                        TwitterLink = c.String(),
                        InstagramLink = c.String(),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.ProductComments", "ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductComments", "ParentId", c => c.Int());
            DropTable("dbo.OurTeams");
            CreateIndex("dbo.ProductComments", "ParentId");
            AddForeignKey("dbo.ProductComments", "ParentId", "dbo.ProductComments", "Id");
        }
    }
}

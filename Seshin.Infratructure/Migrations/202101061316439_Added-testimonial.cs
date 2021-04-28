namespace SpadStore.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedtestimonial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Image = c.String(),
                        Description = c.String(nullable: false),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
        }
    }
}

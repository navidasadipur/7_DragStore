namespace SpadStore.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedproductcomment : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductComments", "ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductComments", "ParentId", c => c.Int());
        }
    }
}

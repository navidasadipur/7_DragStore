namespace SpadStore.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedFeatueFieldOrderPriority : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Features", "OrderPriority", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Features", "OrderPriority");
        }
    }
}

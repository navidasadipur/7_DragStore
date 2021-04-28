namespace Seshin.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDeadLineDiscount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Discounts", "DeadLine", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Discounts", "DeadLine");
        }
    }
}

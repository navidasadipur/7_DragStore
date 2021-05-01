namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColorCodetoProductColors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductColors", "ColorCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductColors", "ColorCode");
        }
    }
}

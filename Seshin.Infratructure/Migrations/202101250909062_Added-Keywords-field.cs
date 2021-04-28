namespace Seshin.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedKeywordsfield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Keywords", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Keywords");
        }
    }
}

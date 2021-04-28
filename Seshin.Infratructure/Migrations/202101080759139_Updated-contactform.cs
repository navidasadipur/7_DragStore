namespace Seshin.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedcontactform : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactForms", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactForms", "Message", c => c.String());
        }
    }
}

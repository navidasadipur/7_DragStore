namespace SpadStore.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpostalcodeemailtoinvoice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "PostalCode", c => c.String(maxLength: 50));
            AddColumn("dbo.Invoices", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invoices", "Email");
            DropColumn("dbo.Invoices", "PostalCode");
        }
    }
}

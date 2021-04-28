namespace Seshin.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedInvoicewithDiscountCodeId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "DiscountCodeId", c => c.Int());
            CreateIndex("dbo.Invoices", "DiscountCodeId");
            AddForeignKey("dbo.Invoices", "DiscountCodeId", "dbo.DiscountCodes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "DiscountCodeId", "dbo.DiscountCodes");
            DropIndex("dbo.Invoices", new[] { "DiscountCodeId" });
            DropColumn("dbo.Invoices", "DiscountCodeId");
        }
    }
}

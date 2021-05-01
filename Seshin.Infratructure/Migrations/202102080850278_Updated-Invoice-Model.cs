namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedInvoiceModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "DiscountAmount", c => c.Long(nullable: false));
            AddColumn("dbo.Invoices", "TotalPriceBeforeDiscount", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invoices", "TotalPriceBeforeDiscount");
            DropColumn("dbo.Invoices", "DiscountAmount");
        }
    }
}

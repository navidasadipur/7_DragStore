namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedEpaymentFieldPaymentStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EPayments", "PaymentStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EPayments", "PaymentStatus");
        }
    }
}

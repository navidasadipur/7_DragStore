namespace SpadStore.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedUserAddedVerificationCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "VerificationCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "VerificationCode");
        }
    }
}

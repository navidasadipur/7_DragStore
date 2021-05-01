namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedProductMainFeatureAddedFieldAdditionalInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductMainFeatures", "AdditionalInfo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductMainFeatures", "AdditionalInfo");
        }
    }
}

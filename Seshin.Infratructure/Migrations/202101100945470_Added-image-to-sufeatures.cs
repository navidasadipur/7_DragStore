namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedimagetosufeatures : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubFeatures", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubFeatures", "Image");
        }
    }
}

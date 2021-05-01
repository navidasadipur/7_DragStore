namespace drugStore7.Infratructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSMSLogTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SMSLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SMSProvider = c.String(),
                        ReceiverMobileNo = c.String(),
                        MessageBody = c.String(),
                        SendDateTime = c.DateTime(nullable: false),
                        IsFlash = c.Boolean(nullable: false),
                        PatternCode = c.String(),
                        LineNumberId = c.Int(),
                        LineNumber = c.String(),
                        ResponseMessage = c.String(),
                        BatchKey = c.String(),
                        PanelMessageId = c.String(),
                        InsertUser = c.String(),
                        InsertDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SMSLogs");
        }
    }
}

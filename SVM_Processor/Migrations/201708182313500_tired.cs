namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tired : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tblmodeofpayment",
                c => new
                    {
                        ModeOfPaymentId = c.Int(nullable: false, identity: true),
                        ModeOfPaymentDesc = c.String(unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ModeOfPaymentId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tblmodeofpayment");
        }
    }
}

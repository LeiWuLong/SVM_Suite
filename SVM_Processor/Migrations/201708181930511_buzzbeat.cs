namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buzzbeat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tblpayment",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ModeOfPayment = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        ChequeNumber = c.Int(),
                        BankId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tblpayment");
        }
    }
}

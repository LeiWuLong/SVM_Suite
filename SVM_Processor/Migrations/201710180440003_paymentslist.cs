namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paymentslist : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblpayment", "TransactionDate", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("tblpayment", "TransactionDate");
        }
    }
}

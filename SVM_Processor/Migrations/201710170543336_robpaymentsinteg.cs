namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class robpaymentsinteg : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "tblbank", newName: "tbldimbank");
            AlterColumn("tblpayment", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("tblpayment", "Amount", c => c.Int(nullable: false));
            RenameTable(name: "tbldimbank", newName: "tblbank");
        }
    }
}

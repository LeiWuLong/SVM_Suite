namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class penalizedfee : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblpayment", "PenalizedFee", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblpayment", "PenalizedFee");
        }
    }
}

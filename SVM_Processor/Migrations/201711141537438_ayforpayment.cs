namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ayforpayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblacademicyear", "isCurrent", c => c.Boolean(nullable: false));
            AddColumn("tblpayment", "SchoolYearId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblpayment", "SchoolYearId");
            DropColumn("tblacademicyear", "isCurrent");
        }
    }
}

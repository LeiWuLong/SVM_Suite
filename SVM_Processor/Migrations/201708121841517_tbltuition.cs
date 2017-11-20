namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbltuition : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbltuition", "Fee", c => c.Double(nullable: false));
            AddColumn("tbltuition", "DimTuitionId", c => c.Int(nullable: false));
            DropColumn("tbltuition", "LevelId");
            DropColumn("tbltuition", "TuitionFee");
            DropColumn("tbltuition", "MiscFee");
            DropColumn("tbltuition", "PaymentTerm");
            DropColumn("tbltuition", "DimEnrollmentId");
        }
        
        public override void Down()
        {
            AddColumn("tbltuition", "DimEnrollmentId", c => c.Int(nullable: false));
            AddColumn("tbltuition", "PaymentTerm", c => c.Int(nullable: false));
            AddColumn("tbltuition", "MiscFee", c => c.Double(nullable: false));
            AddColumn("tbltuition", "TuitionFee", c => c.Double(nullable: false));
            AddColumn("tbltuition", "LevelId", c => c.Int(nullable: false));
            DropColumn("tbltuition", "DimTuitionId");
            DropColumn("tbltuition", "Fee");
        }
    }
}

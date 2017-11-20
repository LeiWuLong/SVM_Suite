namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAssessment : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "SiblingDiscount", c => c.Double(nullable: false));
            AddColumn("tblassessment", "ReferralDiscount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "ReferralDiscount");
            DropColumn("tblassessment", "SiblingDiscount");
        }
    }
}

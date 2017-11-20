namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assessmentrevised : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("tbldimdiscounttype", "tblassessment_AssessmentId", "tblassessment");
            DropIndex("tbldimdiscounttype", new[] { "tblassessment_AssessmentId" });
            CreateTable(
                "tblsiblingreferralmap",
                c => new
                    {
                        SiblingReferralMapId = c.Int(nullable: false, identity: true),
                        SiblingReferralId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        SYId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiblingReferralMapId)                ;
            
            AddColumn("tblassessment", "FullAmount", c => c.Double(nullable: false));
            AddColumn("tblassessment", "Downpayment", c => c.Double(nullable: false));
            AddColumn("tblassessment", "PaymentPerDue", c => c.Double(nullable: false));
            AddColumn("tblassessment", "Discount", c => c.Double(nullable: false));
            DropColumn("tblassessment", "FullTuitionFee");
            DropColumn("tblassessment", "FullMiscFee");
            DropColumn("tblassessment", "TuitionFeePerTerm");
            DropColumn("tblassessment", "MiscFeePerTerm");
            DropColumn("tbldimdiscounttype", "tblassessment_AssessmentId");
        }
        
        public override void Down()
        {
            AddColumn("tbldimdiscounttype", "tblassessment_AssessmentId", c => c.Int());
            AddColumn("tblassessment", "MiscFeePerTerm", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("tblassessment", "TuitionFeePerTerm", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("tblassessment", "FullMiscFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("tblassessment", "FullTuitionFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("tblassessment", "Discount");
            DropColumn("tblassessment", "PaymentPerDue");
            DropColumn("tblassessment", "Downpayment");
            DropColumn("tblassessment", "FullAmount");
            DropTable("tblsiblingreferralmap");
            CreateIndex("tbldimdiscounttype", "tblassessment_AssessmentId");
            AddForeignKey("tbldimdiscounttype", "tblassessment_AssessmentId", "tblassessment", "AssessmentId");
        }
    }
}

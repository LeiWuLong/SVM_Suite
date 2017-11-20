namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paths : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "FullTuitionFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("tblassessment", "FullMiscFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("tblassessment", "TuitionFeePerTerm", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("tblassessment", "MiscFeePerTerm", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("tblassessment", "path", c => c.String(unicode: false));
            AddColumn("tbldimdiscounttype", "tblassessment_AssessmentId", c => c.Int());
            AddColumn("tblpayment", "isDownpayment", c => c.Boolean(nullable: false));
            CreateIndex("tbldimdiscounttype", "tblassessment_AssessmentId");
            AddForeignKey("tbldimdiscounttype", "tblassessment_AssessmentId", "tblassessment", "AssessmentId");
        }
        
        public override void Down()
        {
            DropForeignKey("tbldimdiscounttype", "tblassessment_AssessmentId", "tblassessment");
            DropIndex("tbldimdiscounttype", new[] { "tblassessment_AssessmentId" });
            DropColumn("tblpayment", "isDownpayment");
            DropColumn("tbldimdiscounttype", "tblassessment_AssessmentId");
            DropColumn("tblassessment", "path");
            DropColumn("tblassessment", "MiscFeePerTerm");
            DropColumn("tblassessment", "TuitionFeePerTerm");
            DropColumn("tblassessment", "FullMiscFee");
            DropColumn("tblassessment", "FullTuitionFee");
        }
    }
}

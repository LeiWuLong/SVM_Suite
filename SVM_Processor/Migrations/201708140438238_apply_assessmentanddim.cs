namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class apply_assessmentanddim : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tblacademicyear",
                c => new
                    {
                        AcademicYearId = c.Int(nullable: false, identity: true),
                        AcademicYear = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.AcademicYearId)                ;
            
            CreateTable(
                "tblassessment",
                c => new
                    {
                        AssessmentId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        Section = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        ValidUntil = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.AssessmentId)                ;
            
            CreateTable(
                "tbldimsection",
                c => new
                    {
                        SectionId = c.Int(nullable: false, identity: true),
                        SectionName = c.String(unicode: false),
                        EducationalLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SectionId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tbldimsection");
            DropTable("tblassessment");
            DropTable("tblacademicyear");
        }
    }
}

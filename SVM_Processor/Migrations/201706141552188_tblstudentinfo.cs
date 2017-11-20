namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblstudentinfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblhealthconcern",
                c => new
                    {
                        HealthConcernId = c.Int(nullable: false, identity: true),
                        HealthConcernDesc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.HealthConcernId);
            
            CreateTable(
                "dbo.tblrelationship",
                c => new
                    {
                        RelationshipId = c.Int(nullable: false, identity: true),
                        RelationshipName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.RelationshipId);
            
            CreateTable(
                "dbo.tblstudentdetails",
                c => new
                    {
                        StudentDetailsId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        EducationalLevelId = c.Int(nullable: false),
                        SchoolNameAndAddress = c.String(unicode: false),
                        SchoolYear = c.Int(nullable: false),
                        AwardsReceived = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.StudentDetailsId);
            
            CreateTable(
                "dbo.tblstudenthealthrecord",
                c => new
                    {
                        StudentHealthRecordId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ChildsDoctor = c.String(unicode: false),
                        DoctorsBusinessNameAndAddress = c.String(unicode: false),
                        DoctorsEmergencyTel = c.String(unicode: false),
                        PersonToNotify = c.String(unicode: false),
                        Relationship = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Immunization = c.Int(nullable: false),
                        HealthConcern = c.Int(nullable: false),
                        Allergies = c.String(unicode: false),
                        ConditionHindrance = c.String(unicode: false),
                        SpecialCare = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.StudentHealthRecordId);
            
            DropTable("dbo.tblsuffix");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblsuffix",
                c => new
                    {
                        SuffixId = c.Int(nullable: false, identity: true),
                        SuffixDesc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SuffixId);
            
            DropTable("dbo.tblstudenthealthrecord");
            DropTable("dbo.tblstudentdetails");
            DropTable("dbo.tblrelationship");
            DropTable("dbo.tblhealthconcern");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class family_backgroud : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblstudentfamily",
                c => new
                    {
                        StudentFamilyId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        RelationshipId = c.Int(nullable: false),
                        Citizenship = c.String(unicode: false),
                        Religion = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        TelNo = c.String(unicode: false),
                        MobileNo = c.String(unicode: false),
                        eMail = c.String(unicode: false),
                        Occupation = c.String(unicode: false),
                        EmployerBizAddress = c.String(unicode: false),
                        LastSchoolAttended = c.String(unicode: false),
                        YearGraduated = c.String(unicode: false),
                        EducationalAttainment = c.String(unicode: false),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.StudentFamilyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblstudentfamily");
        }
    }
}

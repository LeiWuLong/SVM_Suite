namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentmodule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblstudent",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentNo = c.Int(nullable: false),
                        EducationalLevelId = c.Int(nullable: false),
                        SchoolNameAndAddress = c.String(unicode: false),
                        SchoolYear = c.Int(nullable: false),
                        AwardsReceived = c.String(unicode: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            AddColumn("dbo.tblstudenthealthrecord", "isDeleted", c => c.Boolean(nullable: false));
            DropTable("dbo.tblstudentdetails");
        }
        
        public override void Down()
        {
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
            
            DropColumn("dbo.tblstudenthealthrecord", "isDeleted");
            DropTable("dbo.tblstudent");
        }
    }
}

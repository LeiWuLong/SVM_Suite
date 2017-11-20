namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dimenrollment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbldimenrollment",
                c => new
                    {
                        DimEnrollmentId = c.Int(nullable: false, identity: true),
                        EnrollmentCode = c.Int(nullable: false),
                        TermId = c.Int(nullable: false),
                        PaymentTermId = c.Int(nullable: false),
                        LevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DimEnrollmentId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tbldimenrollment");
        }
    }
}

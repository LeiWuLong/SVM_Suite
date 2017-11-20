namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assessmentstatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbldimassessmentstatus",
                c => new
                    {
                        AssessmentStatusKey = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        StatusCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AssessmentStatusKey) ;
            
        }
        
        public override void Down()
        {
            DropTable("tbldimassessmentstatus");
        }
    }
}

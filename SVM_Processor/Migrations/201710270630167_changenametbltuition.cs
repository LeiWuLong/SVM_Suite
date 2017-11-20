namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changenametbltuition : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbltuition", "DimEnrollmentId", c => c.Int(nullable: false));
            DropColumn("tbltuition", "DimTuitionId");
        }
        
        public override void Down()
        {
            AddColumn("tbltuition", "DimTuitionId", c => c.Int(nullable: false));
            DropColumn("tbltuition", "DimEnrollmentId");
        }
    }
}

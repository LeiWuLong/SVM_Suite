namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yearenrolled : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblstudent", "YearEnrolled", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblstudent", "YearEnrolled");
        }
    }
}

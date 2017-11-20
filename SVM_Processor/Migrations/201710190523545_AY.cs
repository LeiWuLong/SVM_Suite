namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AY : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblstudent", "AY", c => c.Int(nullable: false));
            DropColumn("tblstudent", "YearEnrolled");
        }
        
        public override void Down()
        {
            AddColumn("tblstudent", "YearEnrolled", c => c.Int(nullable: false));
            DropColumn("tblstudent", "AY");
        }
    }
}

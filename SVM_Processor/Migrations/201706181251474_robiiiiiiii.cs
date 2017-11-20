namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class robiiiiiiii : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblstudent", "EmergencyContact", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblstudent", "EmergencyContact");
        }
    }
}

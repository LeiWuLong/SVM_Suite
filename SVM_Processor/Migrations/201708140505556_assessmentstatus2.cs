namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assessmentstatus2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbldimassessmentstatus", "Status", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbldimassessmentstatus", "Status", c => c.Int(nullable: false));
        }
    }
}

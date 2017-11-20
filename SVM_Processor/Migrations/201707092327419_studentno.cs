namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tblstudent", "StudentNo", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("tblstudent", "StudentNo", c => c.Int(nullable: false));
        }
    }
}

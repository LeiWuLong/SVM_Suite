namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duedatedesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblduedates", "DueDateDesc", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("tblduedates", "DueDateDesc");
        }
    }
}

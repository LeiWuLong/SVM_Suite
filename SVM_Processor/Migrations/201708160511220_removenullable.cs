namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tblassessment", "Section", c => c.Int(nullable: false));
            AlterColumn("tblassessment", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("tblassessment", "Status", c => c.Int());
            AlterColumn("tblassessment", "Section", c => c.Int());
        }
    }
}

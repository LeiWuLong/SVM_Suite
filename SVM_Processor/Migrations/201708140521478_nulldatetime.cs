namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nulldatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tblassessment", "Section", c => c.Int());
            AlterColumn("tblassessment", "Status", c => c.Int());
            AlterColumn("tblassessment", "ValidUntil", c => c.DateTime(precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("tblassessment", "ValidUntil", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("tblassessment", "Status", c => c.Int(nullable: false));
            AlterColumn("tblassessment", "Section", c => c.Int(nullable: false));
        }
    }
}

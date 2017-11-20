namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assessmentmis : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "FullMisc", c => c.Double(nullable: false));
            AddColumn("tblassessment", "DeferredMisc", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "DeferredMisc");
            DropColumn("tblassessment", "FullMisc");
        }
    }
}

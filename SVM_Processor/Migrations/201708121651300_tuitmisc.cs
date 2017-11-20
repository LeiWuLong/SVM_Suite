namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tuitmisc : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbldimenrollment", "TuitMisc", c => c.Int(nullable: false));
            DropColumn("tbldimenrollment", "TermId");
        }
        
        public override void Down()
        {
            AddColumn("tbldimenrollment", "TermId", c => c.Int(nullable: false));
            DropColumn("tbldimenrollment", "TuitMisc");
        }
    }
}

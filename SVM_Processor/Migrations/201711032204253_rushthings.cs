namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rushthings : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "OriginalAmount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "OriginalAmount");
        }
    }
}

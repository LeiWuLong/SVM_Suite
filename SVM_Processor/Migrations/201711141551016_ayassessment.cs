namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ayassessment : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "AY", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "AY");
        }
    }
}

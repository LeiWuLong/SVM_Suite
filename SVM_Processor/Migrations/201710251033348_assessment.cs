namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assessment : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "DateCreated", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "DateCreated");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AYFromTo : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblacademicyear", "AYFrom", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("tblacademicyear", "AYTo", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("tblacademicyear", "YearFrom", c => c.Int(nullable: false));
            AddColumn("tblacademicyear", "YearTo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblacademicyear", "YearTo");
            DropColumn("tblacademicyear", "YearFrom");
            DropColumn("tblacademicyear", "AYTo");
            DropColumn("tblacademicyear", "AYFrom");
        }
    }
}

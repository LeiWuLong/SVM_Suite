namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isalumni : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "isAlumni", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "isAlumni");
        }
    }
}

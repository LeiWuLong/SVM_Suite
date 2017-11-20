namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editassessment : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "EducationalLevel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "EducationalLevel");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isTransferee : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblassessment", "isTransferee", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "isTransferee");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rob3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbluser", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbluser", "isDeleted");
        }
    }
}

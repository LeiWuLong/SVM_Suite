namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gradings : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblpaymentterm", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblpaymentterm", "isDeleted");
        }
    }
}

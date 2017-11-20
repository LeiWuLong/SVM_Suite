namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ispromissory : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblpayment", "isPromissory", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblpayment", "isPromissory");
        }
    }
}

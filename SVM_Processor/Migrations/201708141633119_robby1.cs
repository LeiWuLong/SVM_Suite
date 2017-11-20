namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class robby1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbldimsection", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tbldimsection", "isDeleted");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbluseraccess", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbluseraccess", "UserId", c => c.Int());
        }
    }
}

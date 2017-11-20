namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rob4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbluseraccess", "AccessId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("tbluseraccess");
            AddPrimaryKey("tbluseraccess", "AccessId");
            DropColumn("tbluseraccess", "UserAccessId");
        }
        
        public override void Down()
        {
            AddColumn("tbluseraccess", "UserAccessId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("tbluseraccess");
            AddPrimaryKey("tbluseraccess", "UserAccessId");
            AlterColumn("tbluseraccess", "AccessId", c => c.Int(nullable: false));
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rob2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbluseraccess", "AccessId", c => c.Int(nullable: false));
            DropPrimaryKey("tbluseraccess");
            AddColumn("tbluseraccess", "UserAccessId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("tbluseraccess", "UserAccessId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("tbluseraccess");
            DropColumn("tbluseraccess", "UserAccessId");
            AddPrimaryKey("tbluseraccess", "AccessId");
            AlterColumn("tbluseraccess", "AccessId", c => c.Int(nullable: false, identity: true));
        }
    }
}

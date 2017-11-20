namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dimmiscid2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("tblmisc", "MiscDescription");
        }
        
        public override void Down()
        {
            AddColumn("tblmisc", "MiscDescription", c => c.String(maxLength: 45, storeType: "nvarchar"));
        }
    }
}

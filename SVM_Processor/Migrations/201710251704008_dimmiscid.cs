namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dimmiscid : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblmisc", "DimMiscId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblmisc", "DimMiscId");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class floattodoubletuition : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbltuition", "TuitionFee", c => c.Double(nullable: false));
            AlterColumn("tbltuition", "MiscFee", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbltuition", "MiscFee", c => c.Single(nullable: false));
            AlterColumn("tbltuition", "TuitionFee", c => c.Single(nullable: false));
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dimenrollmentfk : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbltuition", "DimEnrollmentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tbltuition", "DimEnrollmentId");
        }
    }
}

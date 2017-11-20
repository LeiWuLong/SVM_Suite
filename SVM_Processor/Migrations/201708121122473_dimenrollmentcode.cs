namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dimenrollmentcode : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbldimenrollment", "EnrollmentCode", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbldimenrollment", "EnrollmentCode", c => c.Int(nullable: false));
        }
    }
}

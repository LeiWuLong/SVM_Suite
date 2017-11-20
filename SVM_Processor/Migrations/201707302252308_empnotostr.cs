namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empnotostr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbluser", "EmployeeNo", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbluser", "EmployeeNo", c => c.Int(nullable: false));
        }
    }
}

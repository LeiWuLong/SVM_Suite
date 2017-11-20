namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latest1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbluser", "EmployeeNo", c => c.Int(nullable: false));
            AlterColumn("tbluser", "Suffix", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbluser", "Suffix", c => c.String(maxLength: 10, storeType: "nvarchar"));
            DropColumn("tbluser", "EmployeeNo");
        }
    }
}

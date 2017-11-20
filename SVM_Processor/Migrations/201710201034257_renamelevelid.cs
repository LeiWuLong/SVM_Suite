namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamelevelid : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "tbleducationlevel", newName: "tbldimeducationlevel");
            AddColumn("tblassessment", "PaymentTerm", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "PaymentTerm");
            RenameTable(name: "tbldimeducationlevel", newName: "tbleducationlevel");
        }
    }
}

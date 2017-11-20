namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duedates2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tblduedates",
                c => new
                    {
                        DueDatesId = c.Int(nullable: false, identity: true),
                        PaymentTermId = c.Int(nullable: false),
                        DueDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.DueDatesId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tblduedates");
        }
    }
}

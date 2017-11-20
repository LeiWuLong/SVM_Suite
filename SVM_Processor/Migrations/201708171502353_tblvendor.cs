namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblvendor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tblvendor",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        VendorName = c.String(unicode: false),
                        VendorCode = c.String(unicode: false),
                        VendorDescription = c.String(unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VendorId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tblvendor");
        }
    }
}

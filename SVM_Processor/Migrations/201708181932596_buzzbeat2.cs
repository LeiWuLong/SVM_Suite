namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buzzbeat2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tblbank",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        BankName = c.String(unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BankId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tblbank");
        }
    }
}

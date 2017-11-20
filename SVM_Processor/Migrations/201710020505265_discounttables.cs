namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discounttables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tblfamassistdiscount",
                c => new
                    {
                        FamDiscountId = c.Int(nullable: false, identity: true),
                        FamDiscountDesc = c.String(unicode: false),
                        FamDiscountPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FamDiscountId)                ;
            
            DropTable("tbldiscount");
        }
        
        public override void Down()
        {
            CreateTable(
                "tbldiscount",
                c => new
                    {
                        DiscountId = c.Int(nullable: false, identity: true),
                        DiscountDesc = c.String(unicode: false),
                        DiscountAmount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.DiscountId)                ;
            
            DropTable("tblfamassistdiscount");
        }
    }
}

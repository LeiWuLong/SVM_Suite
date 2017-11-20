namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discount2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbldiscount",
                c => new
                    {
                        DiscountId = c.Int(nullable: false, identity: true),
                        DiscountDesc = c.String(unicode: false),
                        DiscountAmount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.DiscountId);
            
        }
        
        public override void Down()
        {
            DropTable("tbldiscount");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discounts2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbldimdiscounttype",
                c => new
                    {
                        DiscountTypeId = c.Int(nullable: false, identity: true),
                        DiscountType = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.DiscountTypeId)                ;
            
            CreateTable(
                "tbldiscount",
                c => new
                    {
                        DiscountId = c.Int(nullable: false, identity: true),
                        DiscountTypeId = c.String(unicode: false),
                        DiscountTypeVal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DiscountId)                ;
            
            AddColumn("tbldimalumnidiscount", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("tbldimearlybirddiscount", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tbldimearlybirddiscount", "isDeleted");
            DropColumn("tbldimalumnidiscount", "isDeleted");
            DropTable("tbldiscount");
            DropTable("tbldimdiscounttype");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discounttables2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "tblfamassistdiscount", newName: "tbldimfamassistdiscount");
            CreateTable(
                "tbldimalumnidiscount",
                c => new
                    {
                        AlumniDiscountId = c.Int(nullable: false, identity: true),
                        AlumniDiscountDesc = c.String(unicode: false),
                        AlumniDiscountPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ModifiedDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.AlumniDiscountId)                ;
            
            CreateTable(
                "tbldimearlybirddiscount",
                c => new
                    {
                        EarlyBirdDiscountId = c.Int(nullable: false, identity: true),
                        EarlyBirdDescription = c.String(unicode: false),
                        DiscountDate = c.DateTime(nullable: false, precision: 0),
                        DiscountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EarlyBirdDiscountId)                ;
            
            CreateTable(
                "tbldimscholarshipdiscount",
                c => new
                    {
                        ScholarshipDiscountId = c.Int(nullable: false, identity: true),
                        ScholarshipDesc = c.String(unicode: false),
                        ScholarshipDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ScholarshipDiscountId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tbldimscholarshipdiscount");
            DropTable("tbldimearlybirddiscount");
            DropTable("tbldimalumnidiscount");
            RenameTable(name: "tbldimfamassistdiscount", newName: "tblfamassistdiscount");
        }
    }
}

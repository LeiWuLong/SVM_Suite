namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class decimaltodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbldiscount", "DiscountTypeVal", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbldiscount", "DiscountTypeVal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}

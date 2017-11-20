namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discounts4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbldiscount", "DiscountTypeDesc", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("tbldiscount", "DiscountTypeDesc");
        }
    }
}

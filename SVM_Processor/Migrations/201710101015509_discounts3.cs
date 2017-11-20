namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discounts3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbldimdiscounttype", "isDeleted", c => c.Boolean(nullable: false));
            AlterColumn("tbldiscount", "DiscountTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbldiscount", "DiscountTypeId", c => c.String(unicode: false));
            DropColumn("tbldimdiscounttype", "isDeleted");
        }
    }
}

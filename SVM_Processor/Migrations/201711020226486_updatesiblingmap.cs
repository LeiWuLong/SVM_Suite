namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatesiblingmap : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblsiblingreferralmap", "DiscountTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblsiblingreferralmap", "DiscountTypeId");
        }
    }
}

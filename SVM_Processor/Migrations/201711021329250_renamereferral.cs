namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamereferral : DbMigration
    {
        public override void Up()
        {
            AddColumn("tblsiblingreferralmap", "ReferredStudentId", c => c.Int(nullable: false));
            DropColumn("tblsiblingreferralmap", "SiblingReferralId");
        }
        
        public override void Down()
        {
            AddColumn("tblsiblingreferralmap", "SiblingReferralId", c => c.Int(nullable: false));
            DropColumn("tblsiblingreferralmap", "ReferredStudentId");
        }
    }
}

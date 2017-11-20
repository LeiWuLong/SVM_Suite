namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class siblingreferral : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbldimreferrals",
                c => new
                    {
                        ReferralId = c.Int(nullable: false, identity: true),
                        Referral = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ReferralId)                ;
            
            CreateTable(
                "tbldimsiblings",
                c => new
                    {
                        SiblingId = c.Int(nullable: false, identity: true),
                        Siblings = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SiblingId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tbldimsiblings");
            DropTable("tbldimreferrals");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblstudenteducationalbackground",
                c => new
                    {
                        LevelId = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(unicode: false),
                        SchoolYear = c.String(unicode: false),
                        AwardsReceived = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.LevelId);
            
            AlterColumn("dbo.tblstudenthealthrecord", "Immunization", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblstudenthealthrecord", "Immunization", c => c.Int(nullable: false));
            DropTable("dbo.tblstudenteducationalbackground");
        }
    }
}

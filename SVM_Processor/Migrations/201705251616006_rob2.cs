namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rob2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbleducationlevel",
                c => new
                    {
                        levelId = c.Int(nullable: false, identity: true),
                        level = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.levelId);
            
        }
        
        public override void Down()
        {
            DropTable("tbleducationlevel");
        }
    }
}

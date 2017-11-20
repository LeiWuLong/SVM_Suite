namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class honors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbldimhonor",
                c => new
                    {
                        HonorId = c.Int(nullable: false, identity: true),
                        Honors = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HonorId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tbldimhonor");
        }
    }
}

namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class schoolyearparam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbldimschoolyearparam",
                c => new
                    {
                        SchoolYearParamId = c.Int(nullable: false, identity: true),
                        SchoolYearDeas = c.String(unicode: false),
                        FromDate = c.DateTime(nullable: false, precision: 0),
                        ToDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.SchoolYearParamId)                ;
            
            AddColumn("tblassessment", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("tblassessment", "isDeleted");
            DropTable("tbldimschoolyearparam");
        }
    }
}

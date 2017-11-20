namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datesparameter2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbldimdateparameter",
                c => new
                    {
                        DateParameterId = c.Int(nullable: false, identity: true),
                        DatesDescription = c.String(unicode: false),
                        FromDate = c.DateTime(nullable: false, precision: 0),
                        ToDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.DateParameterId)                ;
            
        }
        
        public override void Down()
        {
            DropTable("tbldimdateparameter");
        }
    }
}

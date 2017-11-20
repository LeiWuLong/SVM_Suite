namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class honorsrevise : DbMigration
    {
        public override void Up()
        {
            AlterColumn("tbldimhonor", "Honors", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("tbldimhonor", "Honors", c => c.Int(nullable: false));
        }
    }
}

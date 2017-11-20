namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbldimschoolyearparam", "SchoolYearDesc", c => c.String(unicode: false));
            DropColumn("tbldimschoolyearparam", "SchoolYearDeas");
        }
        
        public override void Down()
        {
            AddColumn("tbldimschoolyearparam", "SchoolYearDeas", c => c.String(unicode: false));
            DropColumn("tbldimschoolyearparam", "SchoolYearDesc");
        }
    }
}

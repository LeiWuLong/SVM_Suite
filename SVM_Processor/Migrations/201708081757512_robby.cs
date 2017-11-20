namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class robby : DbMigration
    {
        public override void Up()
        {
            AddColumn("tbltuition", "LevelId", c => c.Int(nullable: false));
            AddColumn("tbltuition", "TuitionFee", c => c.Single(nullable: false));
            AddColumn("tbltuition", "MiscFee", c => c.Single(nullable: false));
            DropColumn("tbltuition", "ToddlerAnnualTuition");
            DropColumn("tbltuition", "ToddlerQuarterTuition");
            DropColumn("tbltuition", "ToddlerMonthlyTuition");
            DropColumn("tbltuition", "ToddlerAnnualMisc");
            DropColumn("tbltuition", "ToddlerQuarterMisc");
            DropColumn("tbltuition", "ToddlerMonthlyMisc");
        }
        
        public override void Down()
        {
            AddColumn("tbltuition", "ToddlerMonthlyMisc", c => c.Single(nullable: false));
            AddColumn("tbltuition", "ToddlerQuarterMisc", c => c.Single(nullable: false));
            AddColumn("tbltuition", "ToddlerAnnualMisc", c => c.Single(nullable: false));
            AddColumn("tbltuition", "ToddlerMonthlyTuition", c => c.Single(nullable: false));
            AddColumn("tbltuition", "ToddlerQuarterTuition", c => c.Single(nullable: false));
            AddColumn("tbltuition", "ToddlerAnnualTuition", c => c.Single(nullable: false));
            DropColumn("tbltuition", "MiscFee");
            DropColumn("tbltuition", "TuitionFee");
            DropColumn("tbltuition", "LevelId");
        }
    }
}

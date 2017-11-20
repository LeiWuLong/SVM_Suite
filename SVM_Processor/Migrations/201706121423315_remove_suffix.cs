namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_suffix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tbluser", "Suffix");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbluser", "Suffix", c => c.Int());
        }
    }
}

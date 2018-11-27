namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SummaryString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "Summary", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "Summary");
        }
    }
}

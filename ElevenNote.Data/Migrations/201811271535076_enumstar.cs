namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enumstar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "IsStarred", c => c.Boolean(nullable: false));
            AddColumn("dbo.Note", "TypeOfImportance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "TypeOfImportance");
            DropColumn("dbo.Note", "IsStarred");
        }
    }
}

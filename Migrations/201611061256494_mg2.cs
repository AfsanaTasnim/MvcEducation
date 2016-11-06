namespace MvcEducation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "Roll", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "Name");
            DropColumn("dbo.Attendances", "Roll");
        }
    }
}

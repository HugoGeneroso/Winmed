namespace Winmed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relatedIdToUserremoval : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "relatedId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "relatedId", c => c.Int(nullable: false));
        }
    }
}

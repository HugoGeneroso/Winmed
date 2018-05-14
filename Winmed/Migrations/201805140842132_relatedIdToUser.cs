namespace Winmed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relatedIdToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "relatedId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "relatedId");
        }
    }
}

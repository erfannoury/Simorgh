namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Constraints : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AlterColumn("dbo.RoomTypes", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.RoomTypes", "Title", c => c.String(nullable: false, maxLength: 60));
            AddPrimaryKey("dbo.RoomTypes", new[] { "Id", "HotelId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AlterColumn("dbo.RoomTypes", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.RoomTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.RoomTypes", "Id");
        }
    }
}

namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Constraints3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AddColumn("dbo.RoomTypes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.RoomTypes", new[] { "Id", "HotelId" });
            DropColumn("dbo.RoomTypes", "RoomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RoomTypes", "RoomId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.RoomTypes");
            DropColumn("dbo.RoomTypes", "Id");
            AddPrimaryKey("dbo.RoomTypes", new[] { "RoomId", "HotelId" });
        }
    }
}

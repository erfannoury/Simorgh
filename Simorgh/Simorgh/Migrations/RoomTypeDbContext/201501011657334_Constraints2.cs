namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Constraints2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AddColumn("dbo.RoomTypes", "RoomId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.RoomTypes", new[] { "RoomId", "HotelId" });
            DropColumn("dbo.RoomTypes", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RoomTypes", "Id", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.RoomTypes");
            DropColumn("dbo.RoomTypes", "RoomId");
            AddPrimaryKey("dbo.RoomTypes", new[] { "Id", "HotelId" });
        }
    }
}

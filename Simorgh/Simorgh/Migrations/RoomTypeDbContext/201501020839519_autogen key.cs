namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class autogenkey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AlterColumn("dbo.RoomTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.RoomTypes", new[] { "Id", "HotelId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AlterColumn("dbo.RoomTypes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.RoomTypes", new[] { "Id", "HotelId" });
        }
    }
}

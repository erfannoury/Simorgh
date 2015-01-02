namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedkey2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AlterColumn("dbo.RoomTypes", "RoomId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.RoomTypes", "RoomId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AlterColumn("dbo.RoomTypes", "RoomId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.RoomTypes", new[] { "RoomId", "HotelId" });
        }
    }
}

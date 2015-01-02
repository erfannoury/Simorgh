namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roomtypeid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RoomTypes");
            AddColumn("dbo.RoomTypes", "RoomTypeId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.RoomTypes", "RoomTypeId");
            DropColumn("dbo.RoomTypes", "RoomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RoomTypes", "RoomId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.RoomTypes");
            DropColumn("dbo.RoomTypes", "RoomTypeId");
            AddPrimaryKey("dbo.RoomTypes", "RoomId");
        }
    }
}

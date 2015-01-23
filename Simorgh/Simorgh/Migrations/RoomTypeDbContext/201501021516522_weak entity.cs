namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class weakentity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RoomTypes");
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageFolderId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 60),
                        CityIdCity = c.Int(nullable: false),
                        Address = c.String(maxLength: 500),
                        Longitude = c.Double(),
                        Latitude = c.Double(),
                        Description = c.String(),
                        Star = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.RoomTypes", "RoomTypeId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.RoomTypes", new[] { "RoomTypeId", "HotelId" });
            CreateIndex("dbo.RoomTypes", "HotelId");
            AddForeignKey("dbo.RoomTypes", "HotelId", "dbo.Hotels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomTypes", "HotelId", "dbo.Hotels");
            DropIndex("dbo.RoomTypes", new[] { "HotelId" });
            DropPrimaryKey("dbo.RoomTypes");
            AlterColumn("dbo.RoomTypes", "RoomTypeId", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Hotels");
            AddPrimaryKey("dbo.RoomTypes", "RoomTypeId");
        }
    }
}

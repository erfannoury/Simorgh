namespace Simorgh.Migrations.HotelDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StrLen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageFolderId = c.Int(nullable: false),
                        Name = c.String(maxLength: 60),
                        CityIdCity = c.Int(nullable: false),
                        Address = c.String(maxLength: 500),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Description = c.String(),
                        Star = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hotels");
        }
    }
}

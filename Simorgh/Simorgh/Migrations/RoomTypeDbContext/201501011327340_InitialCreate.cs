namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelId = c.Int(nullable: false),
                        ImageFolderId = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        RoomCapacity = c.Int(nullable: false),
                        TotalCount = c.Int(nullable: false),
                        VacantCount = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoomTypes");
        }
    }
}

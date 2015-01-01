namespace Simorgh.Migrations.RoomTypeDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StrLen : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RoomTypes", "Title", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RoomTypes", "Title", c => c.String());
        }
    }
}

namespace RentDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Imagelayersize : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentLayers", "Width", c => c.Int(nullable: false));
            AddColumn("dbo.RentLayers", "Height", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RentLayers", "Height");
            DropColumn("dbo.RentLayers", "Width");
        }
    }
}

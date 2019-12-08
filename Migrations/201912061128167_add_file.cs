namespace RentKrok.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_file : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentLayers", "LayerFile", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RentLayers", "LayerFile");
        }
    }
}

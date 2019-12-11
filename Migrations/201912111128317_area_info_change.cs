namespace RentKrok.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class area_info_change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentAreas", "Square", c => c.Single(nullable: false));
            AddColumn("dbo.RentAreas", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.RentAreas", "Cost", c => c.Single(nullable: false));
            DropColumn("dbo.Renters", "Square");
            DropColumn("dbo.Renters", "Price");
            DropColumn("dbo.Renters", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Renters", "Cost", c => c.Single(nullable: false));
            AddColumn("dbo.Renters", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Renters", "Square", c => c.Single(nullable: false));
            DropColumn("dbo.RentAreas", "Cost");
            DropColumn("dbo.RentAreas", "Price");
            DropColumn("dbo.RentAreas", "Square");
        }
    }
}

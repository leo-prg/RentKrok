namespace RentKrok.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix_relations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RentAreas", "Renter_Id", "dbo.Renters");
            DropIndex("dbo.RentAreas", new[] { "Renter_Id" });
            AlterColumn("dbo.RentAreas", "Renter_Id", c => c.Int());
            CreateIndex("dbo.RentAreas", "Renter_Id");
            AddForeignKey("dbo.RentAreas", "Renter_Id", "dbo.Renters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentAreas", "Renter_Id", "dbo.Renters");
            DropIndex("dbo.RentAreas", new[] { "Renter_Id" });
            AlterColumn("dbo.RentAreas", "Renter_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.RentAreas", "Renter_Id");
            AddForeignKey("dbo.RentAreas", "Renter_Id", "dbo.Renters", "Id", cascadeDelete: true);
        }
    }
}

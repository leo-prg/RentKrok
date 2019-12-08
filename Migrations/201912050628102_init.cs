namespace RentKrok.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentAreas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Layer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RentLayers", t => t.Layer_Id, cascadeDelete: true)
                .Index(t => t.Layer_Id);
            
            CreateTable(
                "dbo.RentLayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        LayerFileName = c.String(maxLength: 255),
                        Object_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RentObjects", t => t.Object_Id, cascadeDelete: true)
                .Index(t => t.Object_Id);
            
            CreateTable(
                "dbo.RentObjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentAreas", "Layer_Id", "dbo.RentLayers");
            DropForeignKey("dbo.RentLayers", "Object_Id", "dbo.RentObjects");
            DropIndex("dbo.RentLayers", new[] { "Object_Id" });
            DropIndex("dbo.RentAreas", new[] { "Layer_Id" });
            DropTable("dbo.RentObjects");
            DropTable("dbo.RentLayers");
            DropTable("dbo.RentAreas");
        }
    }
}

namespace DIYTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Units = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectMaterials",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        Project_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectTools",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Project_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Order = c.Int(nullable: false),
                        Description = c.String(),
                        DurationInMinutes = c.String(),
                        Project_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Steps", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.ProjectTools", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.ProjectMaterials", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Projects", "User_Id", "dbo.Users");
            DropIndex("dbo.Steps", new[] { "Project_Id" });
            DropIndex("dbo.ProjectTools", new[] { "Project_Id" });
            DropIndex("dbo.Projects", new[] { "User_Id" });
            DropIndex("dbo.ProjectMaterials", new[] { "Project_Id" });
            DropTable("dbo.Tools");
            DropTable("dbo.Todoes");
            DropTable("dbo.Steps");
            DropTable("dbo.ProjectTools");
            DropTable("dbo.Users");
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectMaterials");
            DropTable("dbo.Materials");
        }
    }
}

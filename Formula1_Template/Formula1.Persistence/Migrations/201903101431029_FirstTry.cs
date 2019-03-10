namespace Formula1.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        ResultId = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        Driver_DriverId = c.Int(),
                        Race_RaceId = c.Int(),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.ResultId)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverId)
                .ForeignKey("dbo.Races", t => t.Race_RaceId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Driver_DriverId)
                .Index(t => t.Race_RaceId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Nationality = c.String(),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.DriverId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        RaceId = c.Int(nullable: false, identity: true),
                        Number = c.Int(),
                        Country = c.String(maxLength: 200),
                        City = c.String(maxLength: 200),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RaceId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Nationality = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Drivers", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Results", "Race_RaceId", "dbo.Races");
            DropForeignKey("dbo.Results", "Driver_DriverId", "dbo.Drivers");
            DropIndex("dbo.Drivers", new[] { "Team_TeamId" });
            DropIndex("dbo.Results", new[] { "Team_TeamId" });
            DropIndex("dbo.Results", new[] { "Race_RaceId" });
            DropIndex("dbo.Results", new[] { "Driver_DriverId" });
            DropTable("dbo.Teams");
            DropTable("dbo.Races");
            DropTable("dbo.Drivers");
            DropTable("dbo.Results");
        }
    }
}

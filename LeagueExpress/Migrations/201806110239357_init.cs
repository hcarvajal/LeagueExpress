namespace LeagueExpress.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        playerFirstName = c.String(nullable: false, maxLength: 200),
                        playerLastName = c.String(),
                        playerMiddileName = c.String(),
                        playerDOB = c.DateTime(nullable: false),
                        playerHeight = c.String(),
                        playerPlaceOfBirth = c.String(),
                        playerName = c.String(),
                        playerNumber = c.Int(nullable: false),
                        playerPosition = c.Int(nullable: false),
                        playerRanking = c.Int(nullable: false),
                        playerApps = c.Int(nullable: false),
                        currentTeam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}

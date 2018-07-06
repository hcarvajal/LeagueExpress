namespace LeagueExpress.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "playerLastName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Players", "playerPhoneNumber", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "playerPhoneNumber", c => c.String(maxLength: 200));
            AlterColumn("dbo.Players", "playerLastName", c => c.String(maxLength: 200));
        }
    }
}

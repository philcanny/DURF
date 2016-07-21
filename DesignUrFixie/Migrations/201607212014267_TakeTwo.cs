namespace DesignUrFixie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TakeTwo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bikes", "FrameColour", c => c.String(nullable: false));
            AlterColumn("dbo.Bikes", "SaddleColour", c => c.String(nullable: false));
            AlterColumn("dbo.Bikes", "HandlebarColour", c => c.String(nullable: false));
            AlterColumn("dbo.Bikes", "WheelColour", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bikes", "WheelColour", c => c.String());
            AlterColumn("dbo.Bikes", "HandlebarColour", c => c.String());
            AlterColumn("dbo.Bikes", "SaddleColour", c => c.String());
            AlterColumn("dbo.Bikes", "FrameColour", c => c.String());
        }
    }
}

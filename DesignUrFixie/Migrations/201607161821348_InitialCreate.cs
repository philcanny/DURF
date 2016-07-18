namespace DesignUrFixie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        BikeId = c.Int(nullable: false, identity: true),
                        FrameColour = c.String(),
                        SaddleColour = c.String(),
                        HandlebarColour = c.String(),
                        WheelColour = c.String(),
                    })
                .PrimaryKey(t => t.BikeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bikes");
        }
    }
}

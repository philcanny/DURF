namespace DesignUrFixie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BikeNameFieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "BikeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "BikeName");
        }
    }
}

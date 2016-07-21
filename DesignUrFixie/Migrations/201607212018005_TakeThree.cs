namespace DesignUrFixie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TakeThree : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bikes", "BikeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bikes", "BikeName", c => c.String());
        }
    }
}

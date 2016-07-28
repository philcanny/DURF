namespace DesignUrFixie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "CustomerName", c => c.String(nullable: false));
            DropColumn("dbo.Bikes", "BikeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bikes", "BikeName", c => c.String(nullable: false));
            DropColumn("dbo.Bikes", "CustomerName");
        }
    }
}

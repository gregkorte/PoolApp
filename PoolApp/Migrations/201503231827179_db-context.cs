namespace PoolApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcontext : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserID", c => c.String());
            AddColumn("dbo.Invoices", "UserID", c => c.String());
            AddColumn("dbo.Products", "UserID", c => c.String());
            AddColumn("dbo.Services", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "UserID");
            DropColumn("dbo.Products", "UserID");
            DropColumn("dbo.Invoices", "UserID");
            DropColumn("dbo.Customers", "UserID");
        }
    }
}

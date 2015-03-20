namespace PoolApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbsetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RouteDay = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zipcode = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        InvoiceNumber = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Company = c.String(),
                        Manufacturer = c.String(),
                        ProductNumber = c.String(),
                        ManufacturerPartNumber = c.String(),
                        UnitOfMeasurement = c.String(),
                        Description = c.String(),
                        Department = c.String(),
                        ProductLine = c.String(),
                        Upc = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        Invoices_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Invoices", t => t.Invoices_ID)
                .Index(t => t.Invoices_ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkUnit = c.String(),
                        Invoices_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Invoices", t => t.Invoices_ID)
                .Index(t => t.Invoices_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Services", "Invoices_ID", "dbo.Invoices");
            DropForeignKey("dbo.Products", "Invoices_ID", "dbo.Invoices");
            DropIndex("dbo.Services", new[] { "Invoices_ID" });
            DropIndex("dbo.Products", new[] { "Invoices_ID" });
            DropIndex("dbo.Invoices", new[] { "CustomerId" });
            DropTable("dbo.Services");
            DropTable("dbo.Products");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
        }
    }
}

namespace Layered.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        RRP = c.Decimal(nullable: false, storeType: "money"),
                        SellingPrice = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => new { t.ProductId, t.ProductName, t.RRP, t.SellingPrice });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
        }
    }
}

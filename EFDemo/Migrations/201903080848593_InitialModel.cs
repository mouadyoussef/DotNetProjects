namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Label = c.String(),
                    Price = c.Double(nullable: false),
                    Description = c.String(),
                    Quantity = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}



namespace AspNetDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RenameLabelToName : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Products", "Label", c => c.String());
            //Sql("UPDATE dbo.Products set Label = Name");
            //DropColumn("dbo.Products", "Name");
            RenameColumn("dbo.Products", "Label", "Name");
        }

        public override void Down()
        {
            RenameColumn("dbo.Products", "Name", "Label");
        }
    }
}

namespace AspNetDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RenameLabelToName : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Products", "Name", c => c.String());
            //Sql("UPDATE dbo.Products set Name = Label");
            //DropColumn("dbo.Products", "Label");
            RenameColumn("dbo.Products", "Label", "Name");
        }

        public override void Down()
        {
            RenameColumn("dbo.Products", "Name", "Label");
        }
    }
}

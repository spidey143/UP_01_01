namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Code", c => c.String());
            DropColumn("dbo.Groups", "FullCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Groups", "FullCode", c => c.String());
            DropColumn("dbo.Groups", "Code");
        }
    }
}

namespace fetchNStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Responses", "ResponseTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Responses", "ResponseTime", c => c.Double(nullable: false));
        }
    }
}

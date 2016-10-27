namespace fetchNStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetimerequesttostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Responses", "TimeRequest", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Responses", "TimeRequest", c => c.DateTime(nullable: false));
        }
    }
}

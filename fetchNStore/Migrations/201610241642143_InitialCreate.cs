namespace fetchNStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Responses",
                c => new
                    {
                        ResponseId = c.Int(nullable: false, identity: true),
                        StatusCode = c.Int(nullable: false),
                        URL = c.String(),
                        ResponseTime = c.Double(nullable: false),
                        HttpMethod = c.String(),
                        TimeRequest = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ResponseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Responses");
        }
    }
}

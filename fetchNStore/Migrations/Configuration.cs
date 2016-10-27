namespace fetchNStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using fetchNStore.DAL;
    using fetchNStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<fetchNStore.DAL.ResponseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(fetchNStore.DAL.ResponseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            
            context.response.AddOrUpdate(
                r => r.URL,
                new Response { StatusCode = 200, URL = "https://facebook.com", ResponseTime = 0.5, HttpMethod = "Get" , TimeRequest=new DateTime(2002,2,3) },
                new Response { StatusCode = 300, URL = "https://amazon.com", ResponseTime = 0.04, HttpMethod = "Get", TimeRequest = new DateTime(2002, 2, 5) },
                new Response { StatusCode = 201, URL = "https://google.com", ResponseTime = 0.2, HttpMethod = "HEAD", TimeRequest = new DateTime(2002, 2, 4) }
                );
        }
    }
}

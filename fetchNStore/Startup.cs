using Microsoft.Owin;
using Owin;
//everything need to config before everything run

[assembly: OwinStartupAttribute(typeof(fetchNStore.Startup))]
namespace fetchNStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

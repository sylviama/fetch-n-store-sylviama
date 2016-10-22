using Microsoft.Owin;
using Owin;

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

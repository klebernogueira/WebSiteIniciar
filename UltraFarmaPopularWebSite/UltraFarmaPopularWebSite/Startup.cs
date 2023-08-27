using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UltraFarmaPopularWebSite.Startup))]
namespace UltraFarmaPopularWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

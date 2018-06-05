using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeagueExpress.Startup))]
namespace LeagueExpress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

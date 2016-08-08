using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasciApps_Lab5.Startup))]
namespace MasciApps_Lab5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppDb.Startup))]
namespace MVCAppDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

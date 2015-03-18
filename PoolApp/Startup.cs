using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoolApp.Startup))]
namespace PoolApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

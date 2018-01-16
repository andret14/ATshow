using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TorsvikApp.Startup))]
namespace TorsvikApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

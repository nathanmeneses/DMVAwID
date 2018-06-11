using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMVAwID.Startup))]
namespace DMVAwID
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

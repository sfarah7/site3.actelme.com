using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Site3.Startup))]
namespace Site3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

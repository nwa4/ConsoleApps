using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormApp.Startup))]
namespace WebFormApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

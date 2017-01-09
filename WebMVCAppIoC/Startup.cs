using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMVCAppIoC.Startup))]
namespace WebMVCAppIoC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

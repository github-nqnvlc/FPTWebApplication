using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FPTWebApplication.Startup))]
namespace FPTWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

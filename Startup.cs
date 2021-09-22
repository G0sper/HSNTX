using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HSNTX.Startup))]
namespace HSNTX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

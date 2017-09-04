using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShinRin.Startup))]
namespace ShinRin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

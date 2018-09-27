using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hotbuns.Startup))]
namespace Hotbuns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

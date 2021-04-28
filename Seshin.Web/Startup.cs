using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seshin.Web.Startup))]
namespace Seshin.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

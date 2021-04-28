using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpadStore.Web.Startup))]
namespace SpadStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

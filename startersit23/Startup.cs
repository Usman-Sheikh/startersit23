using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(startersit23.Startup))]
namespace startersit23
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

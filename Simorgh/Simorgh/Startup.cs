using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simorgh.Startup))]
namespace Simorgh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

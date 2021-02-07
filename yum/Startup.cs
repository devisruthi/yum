using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yum.Startup))]
namespace yum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

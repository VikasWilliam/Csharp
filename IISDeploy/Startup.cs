using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IISDeploy.Startup))]
namespace IISDeploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

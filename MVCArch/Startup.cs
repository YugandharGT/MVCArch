using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCArch.Startup))]
namespace MVCArch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

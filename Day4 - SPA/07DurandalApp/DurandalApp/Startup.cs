using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DurandalApp.Startup))]
namespace DurandalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

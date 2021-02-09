using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HundaiService.Startup))]
namespace HundaiService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

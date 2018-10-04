using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthyEatingWebsite.Startup))]
namespace HealthyEatingWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

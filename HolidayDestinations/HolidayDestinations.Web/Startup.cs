using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HolidayDestinations.Web.Startup))]
namespace HolidayDestinations.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

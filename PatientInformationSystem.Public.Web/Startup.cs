using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PatientInformationSystem.Public.Web.Startup))]
namespace PatientInformationSystem.Public.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

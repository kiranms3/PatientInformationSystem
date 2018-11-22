using System.Web.Http;
using Autofac;
using PatientInformationSystem.Services.API.App_Start;

namespace PatientInformationSystem.Services.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacWebApiConfig.Initialize(GlobalConfiguration.Configuration);

        }
    }
}

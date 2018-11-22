using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using PatientInformationSystem.Services.Core.Manager.Interfaces;
using PatientInformationSystem.Services.Core.Manager.Implementation;
using PatientInformationSystem.Services.Data.Repository.Implementation;
using PatientInformationSystem.Services.Data.Repository.Interfaces;
namespace PatientInformationSystem.Services.API.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<DiagnosticTestManager>()
                   .As<IDiagnosticTestManager>();



            builder.RegisterType<PatientManager>()
                  .As<IPatientManager>();


            builder.RegisterType<DiagnosticTestRepository>()
                  .As<IDiagnosticTestRepository>();


            builder.RegisterType<PatientRepository>()
                  .As<IPatientRepository>();
                

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}
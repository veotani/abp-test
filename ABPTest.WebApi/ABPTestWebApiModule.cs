
using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;
using System.Linq;
using Abp.Application.Services;
using ABPTest.ApplicationServices.Interfaces;

namespace ABPTest
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ABPTestApplicationModule))]
    public class ABPTestWebApiModule : AbpModule
    {
      
    
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(Assembly.GetAssembly(typeof(ABPTestApplicationModule)), "tasksystem")
                .Build();

            ConfigureSwaggerUi();
        }

        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "ABPTest.WebApi");
                    c.ResolveConflictingActions(apiDescription => apiDescription.First());
                    
                })
                .EnableSwaggerUi(c =>
                {
                    c.InjectJavaScript(Assembly.GetAssembly(typeof(ABPTestWebApiModule)), "APBTest.WebApi.Scripts.Swagger-Custom.js");
                });
                
        }
    }
}

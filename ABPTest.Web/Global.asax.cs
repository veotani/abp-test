using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ABPTest.Web
{
    public class MvcApplication : AbpWebApplication<ABPTestWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {


            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                            f => f.UseAbpLog4Net().WithConfig("log4net.config")
                        );

            base.Application_Start(sender, e);
        }
    }
}

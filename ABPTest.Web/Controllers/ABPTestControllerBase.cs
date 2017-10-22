using Abp.Web.Mvc.Controllers;

namespace ABPTest.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ABPTestControllerBase : AbpController
    {
        protected ABPTestControllerBase()
        {
            LocalizationSourceName = ABPTestConsts.LocalizationSourceName;
        }
    }
}
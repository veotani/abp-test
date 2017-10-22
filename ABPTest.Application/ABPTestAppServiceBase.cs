using Abp.Application.Services;

namespace ABPTest
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ABPTestAppServiceBase : ApplicationService
    {
        protected ABPTestAppServiceBase()
        {
            LocalizationSourceName = ABPTestConsts.LocalizationSourceName;
        }
    }
}
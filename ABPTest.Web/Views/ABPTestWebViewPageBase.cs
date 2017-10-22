using Abp.Web.Mvc.Views;

namespace ABPTest.Web.Views
{
    public abstract class ABPTestWebViewPageBase : ABPTestWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPTestWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPTestWebViewPageBase()
        {
            LocalizationSourceName = ABPTestConsts.LocalizationSourceName;
        }
    }
}
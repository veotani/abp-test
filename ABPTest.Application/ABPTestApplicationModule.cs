using System.Reflection;
using Abp.Modules;
using Abp.AutoMapper;

namespace ABPTest
{
    [DependsOn(typeof(ABPTestCoreModule))]
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class ABPTestApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

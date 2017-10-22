using System.Reflection;
using Abp.Modules;

namespace ABPTest
{
    public class ABPTestCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());      
        }
    }
}


using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
namespace ABPTest
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ABPTestCoreModule))]
    public class ABPTestDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

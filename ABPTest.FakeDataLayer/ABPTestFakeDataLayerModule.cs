
using Abp.Modules;
using System.Reflection;
using Abp;
using ABPTest.FakeDataLayer.Repositories;

namespace ABPTest.FakeDataLayer
{
    [DependsOn(typeof(AbpKernelModule))]
    public class ABPTestFakeDataLayerModule : AbpModule
    {
        public override void Initialize()
        {
            //IocManager.IocContainer.Install(new FakeRepositoryInstaller());
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());     
        }
    }
}

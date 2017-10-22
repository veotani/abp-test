using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Abp.Domain.Repositories;

namespace ABPTest.FakeDataLayer.Repositories
{
    public class FakeRepositoryInstaller : IWindsorInstaller
    {
        //Здесь мы устанавливаем, что в качестве реализации общих интерфейсов
        //будем использовать фейковые репозитории
        //аналогичный пример для NHibernate https://github.com/aspnetboilerplate/aspnetboilerplate/blob/f10fa5205c780bcc27adfe38aaae631f412eb7df/src/Abp.NHibernate/NHibernate/Repositories/NhRepositoryInstaller.cs
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var cont = container.Kernel.GetAssignableHandlers(typeof(IRepository<>));

            container.Register(
                    Component.For(typeof(IRepository<>)).ImplementedBy(typeof(FakeRepositoryBase<>)).LifestyleTransient()
            );

            cont = container.Kernel.GetAssignableHandlers(typeof(IRepository<>));

            container.Register(
                Component.For(typeof(IRepository<,>)).ImplementedBy(typeof(FakeRepositoryBase<,>)).LifestyleTransient()
            );

            
        }
    }
}

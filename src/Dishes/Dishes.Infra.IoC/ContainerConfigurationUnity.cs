using Dishes.Application;
using Dishes.Domain.Interfaces.Repository;
using Dishes.Domain.Interfaces.Service;
using Dishes.Domain.Services;
using Dishes.Infra.Data.Repository;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Infra.IoC
{
    public class ContainerConfigurationUnity
    {
        private static readonly Lazy<IUnityContainer> SourceContainer = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterAllServices(container);
            return container;
        });

        private static void RegisterAllServices(IUnityContainer container)
        {
            container
                .RegisterType<IServiceAppMenu, ServiceAppMenu>(new ContainerControlledLifetimeManager())
                .RegisterType<IServiceMenu, ServiceMenu>(new ContainerControlledLifetimeManager())
                .RegisterType<IRepositoryMenu, RepositoryMenu>(new ContainerControlledLifetimeManager());
                
        }
        public static T Resolve<T>()
        {
            return SourceContainer.Value.Resolve<T>();
        }
    }
}

using Dishes.Application;
using Dishes.Domain.Interfaces.Repository;
using Dishes.Domain.Interfaces.Service;
using Dishes.Domain.Services;
using Dishes.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Infra.IoC
{
    public class ContainerConfigurationDictionary
    {
        private static readonly Lazy<Dictionary<Type, object>> _registeredTypes = new Lazy<Dictionary<Type, object>>(
            () =>
        {
            var container = new Dictionary<Type, object>();

            container.Add(typeof(IRepositoryMenu), new RepositoryMenu());
            container.Add(typeof(IServiceMenu), new ServiceMenu((IRepositoryMenu)container[typeof(IRepositoryMenu)]));
            container.Add(typeof(IServiceAppMenu), new ServiceAppMenu((IServiceMenu)container[typeof(IServiceMenu)]));

            return container;
        });

        public static T Resolve<T>()
        {
            return (T)_registeredTypes.Value[typeof(T)];
        }
    }
}

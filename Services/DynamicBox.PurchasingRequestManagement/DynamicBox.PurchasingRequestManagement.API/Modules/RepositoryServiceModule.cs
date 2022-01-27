using Autofac;
using DynamicBox.PurchasingManagement.Core.Repositeries;
using DynamicBox.PurchasingManagement.Core.Services;
using DynamicBox.PurchasingManagement.Core.UnifOfWorks;
using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingManagement.Repository.Repositories;
using DynamicBox.PurchasingManagement.Repository.UnitOfWork;
using DynamicBox.PurchasingManagement.Services.Mapping;
using DynamicBox.PurchasingManagement.Services.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace DynamicBox.PurchasingRequestManagement.API.Modules
{
    public class RepositoryServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>))
                   .As(typeof(IGenericRepository<>))
                   .InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>))
                   .As(typeof(IService<>))
                   .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(DataContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(AutoMapperProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                   .Where(x => x.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                  .Where(x => x.Name.EndsWith("Service"))
                  .AsImplementedInterfaces()
                  .InstancePerLifetimeScope();
        }
    }
}

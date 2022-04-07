using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Mappers;
using System.Linq;

namespace DynamicBox.IdentityServer.Seed
{
    public static class IdentityServerSeedData
    {
        public static void Seed(ConfigurationDbContext context)
        {
            //Clientleri db ye ekleme
            if (!context.Clients.Any())
            {
                foreach (var client in Config.GetClients())
                {
                    context.Clients.Add(client.ToEntity());
                }
            }


            if (!context.ApiResources.Any())
            {
                foreach (var apiResource in Config.GetApiResources())
                {
                    context.ApiResources.Add(apiResource.ToEntity());
                }
            }


            if (!context.ApiScopes.Any())
            {
                foreach (var scope in Config.GetApiScope())
                {
                    context.ApiScopes.Add(scope.ToEntity());
                }
                //Config.GetApiScope().ToList().ForEach(x =>
                //{
                //    context.ApiScopes.Add(x);
                //});
            }


            if (!context.IdentityResources.Any())
            {
                foreach (var resources in Config.GetIdentityResources())
                {
                    context.IdentityResources.Add(resources.ToEntity());
                }
            }


            context.SaveChanges();
        }
    }
}

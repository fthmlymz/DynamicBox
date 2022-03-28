using DynamicBox.IdentityServer.Data;
using DynamicBox.IdentityServer.Models;
using DynamicBox.IdentityServer.Services;
using IdentityServer4;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Logging;
using System.Linq;
using System.Reflection;

namespace DynamicBox.IdentityServer
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        public Startup(IWebHostEnvironment environment, IConfiguration configuration)
        {
            Environment = environment;
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLocalApiAuthentication(); //Herkese açık olduğu için ekleme yapıldı, yerel api doğrulama etkinleştirmek gerekiyor.

            services.AddControllersWithViews();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityServerDbConnection")));


            



            #region Identity Roles
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 2;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            #endregion



            #region Identity Server Configuration
            var assemblyName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
            var builder = services.AddIdentityServer(options =>
            {
                options.Events.RaiseErrorEvents = true;
                options.Events.RaiseInformationEvents = true;
                options.Events.RaiseFailureEvents = true;
                options.Events.RaiseSuccessEvents = true;
                options.EmitStaticAudienceClaim = true;

            })
                .AddConfigurationStore(opts => //Config dosyasını db aktarmak icin
                {
                    opts.ConfigureDbContext = c => c.UseSqlServer(Configuration.GetConnectionString("IdentityServerDbConnection"), sqlOptions => sqlOptions.MigrationsAssembly(assemblyName));
                })
                .AddOperationalStore(opts => //Config dosyasını db aktarmak icin
                {
                    opts.ConfigureDbContext = c => c.UseSqlServer(Configuration.GetConnectionString("IdentityServerDbConnection"), sqlOptions => sqlOptions.MigrationsAssembly(assemblyName));
                })
                //.AddProfileService<ProfileService>()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApiResources())
                .AddInMemoryApiScopes(Config.GetApiScope())
                .AddInMemoryClients(Config.GetClients())
                .AddDeveloperSigningCredential()
                .AddAspNetIdentity<ApplicationUser>();

            services.AddScoped<IResourceOwnerPasswordValidator, IdentityResourceOwnerPasswordValidator>();
            #endregion


            ////connect/userinfo neye baktığını görmek için
            //IdentityModelEventSource.ShowPII = true;








            //builder.AddDeveloperSigningCredential();


            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                    options.ClientId = "DynamicBoxWorkflow";
                    options.ClientSecret = "secret";
                });


            builder.AddDeveloperSigningCredential();
        }

        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthorization();

            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }




    }
}

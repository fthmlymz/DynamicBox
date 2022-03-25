
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOcelot();

#region Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.WithOrigins("https://localhost:4200", "http://localhost:4200") //"https://localhost:4200", "http://localhost:4200"
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithMethods("Get", "Post", "Put", "Delete", "Options"));
});
#endregion


builder.WebHost.ConfigureAppConfiguration((hostingContext, config) =>
{
    config
        .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
        //.AddJsonFile("appsettings.json", true, true)
        .AddJsonFile($"configuration.{hostingContext.HostingEnvironment.EnvironmentName.ToLower()}.json", true, true)
        .AddJsonFile("configuration.development.json")
        .AddJsonFile($"configuration.{hostingContext.HostingEnvironment.EnvironmentName.ToLower()}.json")
        .AddEnvironmentVariables();
});

#region KeyCloak Server -> JWT Auth
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.Authority = builder.Configuration["KeyCloakServerUrl"];
    options.Audience = "PurchasingManagementGateway";
});
#endregion



var app = builder.Build();
app.UseHttpsRedirection();


await app.UseOcelot();

app.UseCors("CorsPolicy");

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.Run();

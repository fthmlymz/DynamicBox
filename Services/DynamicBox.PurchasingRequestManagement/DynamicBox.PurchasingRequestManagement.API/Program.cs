using Autofac;
using Autofac.Extensions.DependencyInjection;
using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingManagement.Services.Mapping;
using DynamicBox.PurchasingRequestManagement.API.Filters;
using DynamicBox.PurchasingRequestManagement.API.MiddlewaresExtension;
using DynamicBox.PurchasingRequestManagement.API.Modules;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers(options =>
{
    options.Filters.Add(new ValidateFilterAttribute());
    //options.Filters.Add(new AuthorizeFilter()); //tüm kontrollerde authorize attribute etkinleþtirilmiþ olacak
}).AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});
//Filteryi özelleþtir.
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();






//#region IdentityServer configuration
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
//{
//    options.Authority = builder.Configuration["IdentityServerUrl"]; //token daðýtan identity server adresi verilecek
//    options.Audience = "resource_purchasingmanagement";
//});
//#endregion


builder.Services.AddCors();



#region Dependencies
builder.Services.AddScoped(typeof(NotFoundFilter<>));
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
#endregion



#region Sql Server Connection
builder.Services.AddDbContext<DataContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("PurchasingDbConnection"), options =>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(DataContext)).GetName().Name);
    });
});
#endregion



builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(conteinerBuilder => conteinerBuilder.RegisterModule(new RepositoryServiceModule()));



var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials());
app.UseStaticFiles(); //api tarafýnda statik dosya tutmak için
app.UseHttpsRedirection();

//Custom middleware
app.UseCustomException();


app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();

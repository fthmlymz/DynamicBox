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
    //options.Filters.Add(new AuthorizeFilter()); //t�m kontrollerde authorize attribute etkinle�tirilmi� olacak
}).AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});
//Filteryi ozellestir.
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



#region Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.WithOrigins("https://localhost:4200", "http://localhost:4200", "https://localhost:2001", "http://localhost:2000") //"https://localhost:4200", "http://localhost:4200", "https://localhost:2001", "http://localhost:2000"
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithMethods("Get", "Post", "Put", "Delete", "Options"));
});
#endregion


//#region IdentityServer configuration
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
//{
//    options.Authority = builder.Configuration["IdentityServerUrl"]; //token da��tan identity server adresi verilecek
//    options.Audience = "resource_purchasingmanagement";
//});
//#endregion

#region Authorization
//builder.Services.AddAuthorization(opts =>
//{
//    opts.AddPolicy("ReadPurchasingManagement", policy =>
//    {
//        policy.RequireClaim("scope", new[] { "purchasing.read" });
//    });

//    opts.AddPolicy("UpdateOrCreate", policy =>
//    {
//        policy.RequireClaim("scope", new[] { "purchasing.create", "purchasing.update" });
//    });

//    opts.AddPolicy("DeletePurchasing", policy =>
//    {
//        policy.RequireClaim("scope", new[] { "purchasing.delete" });
//    });
//});
#endregion






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

app.UseCors("CorsPolicy");


app.UseStaticFiles(); //api taraf�nda statik dosya tutmak i�in
app.UseHttpsRedirection();

//Custom middleware
app.UseCustomException();


app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();

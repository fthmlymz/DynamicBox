using Autofac;
using Autofac.Extensions.DependencyInjection;
using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingManagement.Services.Mapping;
using DynamicBox.PurchasingRequestManagement.API.Filters;
using DynamicBox.PurchasingRequestManagement.API.MiddlewaresExtension;
using DynamicBox.PurchasingRequestManagement.API.Modules;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


#region Health Check
builder.Services.AddHealthChecks();
#endregion

builder.Services.AddControllers(options =>
{
    options.Filters.Add(new ValidateFilterAttribute());
    //options.Filters.Add(new AuthorizeFilter()); //tum kontrollerde authorize attribute etkinle�tirilmis olacak
}).AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});
//Filtereyi ozellestir.
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddEndpointsApiExplorer();

#region Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HastaTakip.API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
#endregion



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


#region Identity Server 4 -> JWT Auth
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.Authority = builder.Configuration["IdentityServer:Authority"];
                    options.Audience = "resource_purchasing";
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters.ValidTypes = new[] { "at+jwt" };
                });

#region Authorization - Claims
builder.Services.AddAuthorization(opts =>
{
    opts.AddPolicy("CreatePurchasingManagement", policy =>
    {
        policy.RequireClaim("scope", new[] { "purchasing.create" });
    });
    opts.AddPolicy("ReadPurchasingManagement", policy =>
    {
        policy.RequireClaim("scope", new[] { "purchasing.read" });
    });
    opts.AddPolicy("UpdatePurchasingManagement", policy =>
    {
        policy.RequireClaim("scope", new[] { "purchasing.update" });
    });
    opts.AddPolicy("DeletePurchasingManagement", policy =>
    {
        policy.RequireClaim("scope", new[] { "purchasing.delete" });
    });
});
#endregion

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


app.UseStaticFiles(); //api tarafinda statik dosya tutmak icin
app.UseHttpsRedirection();

//Custom middleware
app.UseCustomException();


app.UseAuthentication(); //Kimlik dogrulama
app.UseAuthorization();  //Kimlik yetkilendirme


#region Healt Check
app.UseHealthChecks("/health");
#endregion
app.MapControllers().RequireAuthorization();

app.Run();

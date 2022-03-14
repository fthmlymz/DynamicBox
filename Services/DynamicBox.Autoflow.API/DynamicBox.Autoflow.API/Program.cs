using Autoflow.Persistence.EntityFramework.Core.Extensions;
using Autoflow.Persistence.EntityFramework.SqlServer;
using DynamicBox.Autoflow.API.Activities;
using DynamicBox.Autoflow.API.Data;
using MassTransit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Authorization;

using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




#region Autoflow connection strings 
var connectionString = builder.Configuration.GetConnectionString("AutoflowDbConnection");
builder.Services
   .AddDbContextFactory<DataContext>(options => options.UseSqlServer(connectionString))
   .AddCors(cors => cors.AddDefaultPolicy(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()))
   .AddAutoflow(elsa => elsa
       .UseEntityFrameworkPersistence(ef => ef.UseSqlServer(connectionString))
       .AddJavaScriptActivities()
       .AddHttpActivities(builder.Configuration.GetSection("Autoflow").GetSection("Server").Bind)
       .AddEmailActivities(builder.Configuration.GetSection("Autoflow").GetSection("Smtp").Bind)
       .AddActivity<CreatedDocumentConsumer>())
   .AddAutoflowApiEndpoints();
builder.Services.AddAutoflowSwagger();
#endregion


#region RabbitMQ connection conf.
builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<CreatedDocumentConsumer>();

    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host(builder.Configuration["RabbitMQ:Host"], "/", host =>
        {
            host.Username(builder.Configuration["RabbitMQ:Username"]);
            host.Password(builder.Configuration["RabbitMQ:Password"]);
        });

        ////DocumentManagement.API -> Services -> DocumentService Procedure tarafýndan oluþturulan döküman ilk oluþturulduðunda bu dinleyiciyi çalýþtýr
        cfg.ReceiveEndpoint("created-document", e =>
        {
            e.ConfigureConsumer<CreatedDocumentConsumer>(context);
        });
    });
});
builder.Services.AddMassTransitHostedService();
#endregion




#region Razor page defaults
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddControllers(options =>
{
    //options.Filters.Add(new AuthorizeFilter()); //tüm kontrollerde authorize attribute etkinleþtirilmiþ olacak
});
#endregion




#region IdentityServer configuration
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.Authority = builder.Configuration["IdentityServerUrl"]; //token daðýtan identity server adresi verilecek
    options.Audience = "resource_elsaserver";
});
#endregion



#region Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("*",
                                              "http://localhost:4200",
                                              "https://localhost:4200");
                      });
});
#endregion



#region Default app
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MainDashboard.API v1"));
}

app.UseCors(MyAllowSpecificOrigins);


app.UseStaticFiles();
app.UseRouting();
app.UseCors();
//app.UseHttpActivities();
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapFallbackToPage("/_Host");
});

app.Run();
#endregion
 
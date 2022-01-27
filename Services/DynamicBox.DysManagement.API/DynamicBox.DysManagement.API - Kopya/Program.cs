using DynamicBox.DysManagement.API.Data;
using DynamicBox.DysManagement.API.Services.DocumentService;
using DynamicBox.Workflow.DysManagement.API;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

//IApplicationBuilder app



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



#region Sql Server Connection
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DocumentManagementDBConnection"), options =>
{
    options.EnableRetryOnFailure(); //Resiliency kullanıldı
}));
//builder.Services.AddDbContext<DataContext>(opts =>
//{
//    var connString = builder.Configuration.GetConnectionString("DocumentManagementDBConnection");
//    opts.UseSqlServer(connString, options =>
//    {
//        options.MigrationsAssembly(typeof(DataContext).Assembly.FullName.Split(',')[0]);
//    });
//});

#endregion
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//services.AddAutoMapper(typeof(Startup));



builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "DynamicBox.Workflow.DocumentManagement.API", Version = "v1" });
});



#region Models
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IDocumentService, DocumentService>();
#endregion


#region RabbitMQ settings
builder.Services.AddMassTransit(mass =>
{
    //Consumer tanımlamaları
    //mass.AddConsumer<CreatedDocumentConsumer>();

    mass.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host(builder.Configuration["RabbitMQ:Host"], "/", host =>
        {
            host.Username(builder.Configuration["RabbitMQ:Username"]);
            host.Password(builder.Configuration["RabbitMQ:Password"]);
        });

        //cfg.ReceiveEndpoint($"queue:{RabbitMQSettingsConst.DocumentExecutedCreatedCompleted}", e =>
        //{
        //    e.ConfigureConsumer<CreatedDocumentConsumer>(context);
        //});
    });
});
builder.Services.AddMassTransitHostedService();
#endregion





var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DynamicBox.Workflow.DocumentManagement.API v1"));
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.UseHttpsRedirection();
app.Run();



using ServiceContracts;
using Services;
using Microsoft.EntityFrameworkCore;
using Entities;
using RepositoryContracts;
using Repositories;
//using Serilog;
using CRUDExample.Filters.ActionFilters;
using CRUDExample;
using CRUDExample.Middleware;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

//Serilog
//builder.Host.UseSerilog((HostBuilderContext context, IServiceProvider services, LoggerConfiguration loggerConfiguration) => {

//    loggerConfiguration
//    .ReadFrom.Configuration(context.Configuration) //read configuration settings from built-in IConfiguration
//    .ReadFrom.Services(services); //read out current app's services and make them available to serilog
//});

builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();

//app.UseSerilogRequestLogging();

//create application pipeline
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseExceptionHandlingMiddleware();
}
app.UseHsts();
app.UseHttpsRedirection();

app.UseHttpLogging();

if (builder.Environment.IsEnvironment("Test") == false)
    Rotativa.AspNetCore.RotativaConfiguration.Setup("wwwroot", wkhtmltopdfRelativePath: "Rotativa");

app.UseStaticFiles();

app.UseRouting();//Identifying action method to be called based on URL
app.UseAuthentication(); //Reading Identity cookies and populating User object
app.UseAuthorization(); //Checking if user is authorized to access the resource
app.MapControllers(); //Excute the filter pipeline (action + filters)
app.UseEndpoints(endpoints => {
    endpoints.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller=Home}/{action=Index}");

    //Admin/Home/Index
    //Admin

    endpoints.MapControllerRoute(
     name: "default",
     pattern: "{controller}/{action}/{id?}"
     );
});
app.Run();

public partial class Program { } //make the auto-generated Program accessible programmatically
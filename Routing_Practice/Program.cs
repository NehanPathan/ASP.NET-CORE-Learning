var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable routing
app.UseRouting();

//creating end points
app.UseEndpoints(endpoints =>
{
    //add your end points
    endpoints.Map("files/{fileName=temp}.{extension=txt}", async (context) =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["fileName"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);

        await context.Response.WriteAsync($"In file - {fileName} - {extension} ");
    });
    endpoints.Map("employee/profile/{EmployeeName:alpha?}", async (context) =>
    {
        string? EmployeeName = Convert.ToString(context.Request.RouteValues["EmployeeName"]);

        await context.Response.WriteAsync($"In Employee Profile - {EmployeeName}");
    });
   
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();

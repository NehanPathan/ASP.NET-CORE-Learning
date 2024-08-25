var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.Map("/", async context =>
    {
        await context.Response.WriteAsync(app.Configuration["myKey"] + "\n");
        await context.Response.WriteAsync(app.Configuration.GetValue<int>("key",10) + "\n");
    });
});
app.Run();

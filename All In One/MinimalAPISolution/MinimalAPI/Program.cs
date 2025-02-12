var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (HttpContext context) =>
{
    await context.Response.WriteAsync("GET - Hello World!");
});
app.MapPost("/", async (HttpContext context) =>
{
    await context.Response.WriteAsync("POST - Hello World!");
});

app.Run();

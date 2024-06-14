using Middleware_Practice.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();

//middleware 1
// app.Use(async (HttpContext context, RequestDelegate next) =>
// {
//     await context.Response.WriteAsync("From Middleware 1");
//     await next(context);
// });

//middleware 2
// app.UseMiddleware<MyCustomMiddleware>();
// app.UseMyCustomMiddleware();
// app.UseHelloCustomMiddleware();

//middleware 3
// app.Run(async (HttpContext context) =>
// {
//     await context.Response.WriteAsync(" From Middleware 3");
// });

//UseWhen type middleware
app.UseWhen(
    context => context.Request.Query.ContainsKey("userName"),
    app =>
    {
        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("Hello from Middleware Branch");
            await next();
        });
    }
);
app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from Middleware at main chain");
});

app.Run();

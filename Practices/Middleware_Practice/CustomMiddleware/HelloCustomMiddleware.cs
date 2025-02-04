using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Middleware_Practice.CustomMiddleware
{
    public class HelloCustomMiddleware
{
    private readonly RequestDelegate _next;

    public HelloCustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        //before logic
        await _next(context);
        //after logic
    }
}
public static class UseHelloCustomMiddlewareExtensions
{
    public static IApplicationBuilder UseHelloCustomMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<HelloCustomMiddleware>();
    }
}
}
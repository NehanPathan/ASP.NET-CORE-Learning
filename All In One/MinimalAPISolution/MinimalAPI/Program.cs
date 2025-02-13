using MinimalAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Product> products = new()
{
    new Product { Id = 1, ProductName = "Smart Phone" },
    new Product { Id = 2, ProductName = "Laptop" },
    new Product { Id = 3, ProductName = "Tablet" }
}; 

//GET /products
app.MapGet("/products", async (HttpContext context) =>
{
    var content = string.Join("\n", products.Select(p => p.ToString()));
    //1, xxxx
    //2, yyyy

    await context.Response.WriteAsync(content);
});
app.MapPost("/products", async (HttpContext context, Product product) =>
{
    products.Add(product);
    await context.Response.WriteAsync("Product Added");
});

app.Run();

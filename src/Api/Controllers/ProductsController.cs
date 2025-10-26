namespace BugStore.Api.Controllers
{
    public static class ProductsController
    {
        public static void MapProductsEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/v1/products");

            group.MapGet("/", () => "Hello World!");
            group.MapGet("/{id}", () => "Hello World!");
            group.MapPost("/", () => "Hello World!");
            group.MapPut("/{id}", () => "Hello World!");
            group.MapDelete("/{id}", () => "Hello World!");
        }
    }
}

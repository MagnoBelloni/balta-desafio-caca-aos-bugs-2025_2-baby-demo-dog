namespace BugStore.Api.Controllers
{
    public static class OrdersController
    {
        public static void MapOrdersEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/v1/orders");

            group.MapGet("/{id}", () => "Hello World!");
            group.MapPost("/", () => "Hello World!");
        }
    }
}

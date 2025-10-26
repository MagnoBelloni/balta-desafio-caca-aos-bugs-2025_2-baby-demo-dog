using BugStore.Data;
using BugStore.Data.Repositories;
using BugStore.Domain.Interfaces.Repositories;
using System.Reflection;

namespace BugStore
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddDataDependencies();
            
            return services;
        }

        private static IServiceCollection AddDataDependencies(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}

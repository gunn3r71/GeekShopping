using GeekShopping.Services.Products.Domain.Interfaces.Repositories;
using GeekShopping.Services.Products.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GeekShopping.Services.Products.API.Extensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}

using System;
using GeekShopping.Services.Products.API.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace GeekShopping.Services.Products.API.Extensions
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddSingleton(Mapper.RegisterMaps().CreateMapper());
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}

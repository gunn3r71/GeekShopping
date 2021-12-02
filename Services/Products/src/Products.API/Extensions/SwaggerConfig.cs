using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace GeekShopping.Services.Products.API.Extensions
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Products.API",
                    Version = "v1",
                    Description = "Primeira API desenvolvida no curso de microsserviços",
                    Contact = new OpenApiContact
                    {
                        Name = "Lucas Pereira",
                        Email = "lucas.p.oliveira@outlook.pt"
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT"
                    }
                });
            });

            return services;
        }
    }
}

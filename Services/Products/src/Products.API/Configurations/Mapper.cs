using AutoMapper;
using GeekShopping.Services.Products.API.Models.OutputModels;
using GeekShopping.Services.Products.Domain.Entities;

namespace GeekShopping.Services.Products.API.Configurations
{
    public static class Mapper
    {
        public static MapperConfiguration RegisterMaps()
        {
            return new (x =>
            {
                x.CreateMap<ProductModel, Product>();
                x.CreateMap<Product, ProductModel>();

                x.CreateMap<Category, CategoryModel>();
            });
        }
    }
}

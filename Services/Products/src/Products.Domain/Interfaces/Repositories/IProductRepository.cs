using System;
using System.Threading.Tasks;
using GeekShopping.Services.Products.Domain.Entities;
using GeekShopping.Services.Products.Domain.Interfaces.Repositories.Base;

namespace GeekShopping.Services.Products.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
    }
}
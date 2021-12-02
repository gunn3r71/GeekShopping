using System;
using System.Threading.Tasks;
using GeekShopping.Services.Products.Domain.Entities;
using GeekShopping.Services.Products.Domain.Interfaces.Repositories.Base;

namespace GeekShopping.Services.Products.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<bool> Remove(Guid productId);
    }
}
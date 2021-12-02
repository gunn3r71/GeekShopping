using GeekShopping.Services.Products.Domain.Entities;
using GeekShopping.Services.Products.Domain.Interfaces.Repositories.Base;

namespace GeekShopping.Services.Products.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
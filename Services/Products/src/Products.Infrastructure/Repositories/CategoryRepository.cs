using GeekShopping.Services.Products.Domain.Entities;
using GeekShopping.Services.Products.Domain.Interfaces.Repositories;
using GeekShopping.Services.Products.Infrastructure.Repositories.Base;

namespace GeekShopping.Services.Products.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProductsContext productsContext) : base(productsContext)
        {
        }
    }
}

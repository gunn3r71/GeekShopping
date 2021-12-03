using GeekShopping.Services.Products.Domain.Entities;
using GeekShopping.Services.Products.Domain.Interfaces.Repositories;
using GeekShopping.Services.Products.Infrastructure.Repositories.Base;
using System.Threading.Tasks;

namespace GeekShopping.Services.Products.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductsContext productsContext) : base(productsContext)
        {
        }

        public async Task<Product> Create(Product product)
        {
            _entity.Add(product);
            await Commit();

            return product;
        }
        

        public async Task<Product> Update(Product product)
        {
            _entity.Update(product);
            await Commit();

            return product;
        }
    }
}
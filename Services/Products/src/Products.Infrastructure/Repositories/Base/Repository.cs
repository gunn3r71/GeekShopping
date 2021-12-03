using GeekShopping.Services.Products.Domain.Entities.Base;
using GeekShopping.Services.Products.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Services.Products.Infrastructure.Repositories.Base
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly ProductsContext _productsContext;
        protected readonly DbSet<T> _entity;

        protected Repository(ProductsContext productsContext)
        {
            _productsContext = productsContext;
            _entity = _productsContext.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public virtual async Task<T> FindByIdAsync(Guid entityId)
        {
            return await _entity.FirstOrDefaultAsync(x => x.Id == entityId);
        }

        public async Task Commit()
        {
            await _productsContext.SaveChangesAsync();
        }
    }
}

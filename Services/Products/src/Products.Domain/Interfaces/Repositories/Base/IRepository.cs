using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GeekShopping.Services.Products.Domain.Entities.Base;

namespace GeekShopping.Services.Products.Domain.Interfaces.Repositories.Base
{
    public interface IRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> FindAllAsync();
        Task<T> FindByIdAsync(Guid entityId);
    }
}
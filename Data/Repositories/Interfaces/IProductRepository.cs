using Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetIsPromoAsync();
        Task<IEnumerable<Product>> GetCatalogueAsync(int categoryId);
    }
}

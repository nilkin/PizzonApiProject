using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(PizzonDbContext context): base(context){ }
        private PizzonDbContext _context => Context as PizzonDbContext;

        public async Task<IEnumerable<Product>> GetCatalogueAsync(int categoryId)
        {
            return await _context.Products
                .Include(p => p.Stock)
                .Include(c => c.Category)
                .Where(c =>c.CategoryId == categoryId).Take(6).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetIsPromoAsync()
        {
            return await _context.Products.Where(c=>c.IsPromo).OrderBy(c => c.OrderBy).ToListAsync();
        }


    }
}


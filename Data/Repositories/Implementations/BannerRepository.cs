using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class BannerRepository : Repository<Banner>, IBannerRepository
    {

        public BannerRepository(PizzonDbContext context): base(context){ }
        private PizzonDbContext _context => Context as PizzonDbContext;

        public async Task<IEnumerable<Banner>> GetIsBannerAsync()
        {
            return await _context.Banners.Where(c => c.IsBanner ).ToListAsync();
        }

        public async Task<IEnumerable<Banner>> GetIsServiceAsync()
        {
            return await _context.Banners.Where(c => c.IsService).ToListAsync();
        }
    }
}


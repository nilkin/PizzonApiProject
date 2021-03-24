using Data.Entities;
using Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class AboutUsRepository : Repository<AboutUs>, IAboutUsRepository
    {
        public AboutUsRepository(PizzonDbContext context) : base(context) { }
        private PizzonDbContext _context => Context as PizzonDbContext;

        //public async Task<IEnumerable<AboutUs>> GetAboutAsync()
        //{
        //    return await _context.AboutUs.Where(c => c.IsHome).ToList();
        //}


    }
}

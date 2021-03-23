using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
   public class BlogRepository: Repository<Blog>, IBlogRepository
    {
        public BlogRepository(PizzonDbContext context): base(context){ }
        private PizzonDbContext _context => Context as PizzonDbContext;

        public async Task<IEnumerable<Blog>> GetIsNewAsync()
        {
            return await _context.Blogs.Where(c => c.IsNew).OrderBy(c=>c.OrderBy).Take(3).ToListAsync();
        }
    }
}

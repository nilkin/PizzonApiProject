using Data.Repositories.Implementations;
using Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork

    {
        private readonly PizzonDbContext _context;
        private readonly BannerRepository _bannerRepository;
        private readonly ProductRepository _productRepository;
        private readonly AssociateRepository _associateRepository;
        private readonly BlogRepository _blogRepository;

        public UnitOfWork(PizzonDbContext context)
        {
            _context = context;
        }
        public IBannerRepository Banner => _bannerRepository ?? new BannerRepository(_context);
        public IProductRepository Product => _productRepository ?? new ProductRepository(_context);
        public IAssociateRepository Associate => _associateRepository ?? new AssociateRepository(_context);
        public IBlogRepository Blogs => _blogRepository ?? new BlogRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

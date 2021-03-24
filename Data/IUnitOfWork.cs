using Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Data
{
     public interface IUnitOfWork 
    {
        IBannerRepository Banner { get; }
        IProductRepository Product { get; }
        IAssociateRepository Associate { get; }
        IBlogRepository Blogs { get; }
        ITestimonialRepository Testimonials { get; }
        IAboutUsRepository Abouts { get; }

        Task<int> CommitAsync();
    }
}

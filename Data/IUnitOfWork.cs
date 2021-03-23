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
        Task<int> CommitAsync();
    }
}

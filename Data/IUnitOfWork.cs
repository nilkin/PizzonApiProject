using Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Data
{
     public interface IUnitOfWork 
    {
        IBannerRepository Banner { get; }
        IProductRepository Product { get; }
        Task<int> CommitAsync();
    }
}

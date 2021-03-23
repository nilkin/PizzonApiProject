using Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Data
{
     public interface IUnitOfWork 
    {
        IBannerRepository Banner { get; }
        IProductRepository Product { get; }
        IAssociateRepository Associate { get; }
        Task<int> CommitAsync();
    }
}

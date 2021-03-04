using Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IBannerRepository : IRepository<Banner>
    {
        Task<IEnumerable<Banner>> GetIsBannerAsync();
        Task<IEnumerable<Banner>> GetIsServiceAsync();
    }
}

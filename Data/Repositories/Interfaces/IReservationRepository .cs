using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<bool> AnyAsync(string email);
    }
}

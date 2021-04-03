using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {

        public ReservationRepository(PizzonDbContext context): base(context){ }
        private PizzonDbContext _context => Context as PizzonDbContext;

        public async Task<bool> AnyAsync(string email)
        {
            return await _context.Reservations.AnyAsync(s=>s.Email == email);
        }
    }
}


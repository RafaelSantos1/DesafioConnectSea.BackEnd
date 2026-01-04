using DesafioConnectSea.Domain.Entities;
using DesafioConnectSea.Domain.Interface.Repositories;
using DesafioConnectSea.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Infrastructure.Persistence.Repositories
{
    public class EscalaRepository : IEscalaRepository
    {
        private readonly DesafioConnectSeaDbContext _context;
        public EscalaRepository(DesafioConnectSeaDbContext context)
        {
            _context = context;
        }
        public async Task<List<Escala>> GetAllAsync()
        {
            return await _context.Escalas.ToListAsync();
        }

        public async Task AddAsync(Escala escala)
        {
            await _context.Escalas.AddAsync(escala);
            await _context.SaveChangesAsync();
        }
    }
}

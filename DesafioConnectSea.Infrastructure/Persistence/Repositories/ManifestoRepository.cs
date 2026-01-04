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
    public class ManifestoRepository : IManifestoRepository
    {
        private readonly DesafioConnectSeaDbContext _context;
        public ManifestoRepository(DesafioConnectSeaDbContext context)
        {
            _context = context;
        }
        public async Task<List<Manifesto>> GetAllAsync()
        {
            return await _context.Manifestos.ToListAsync();
        }
        public async Task AddAsync(Manifesto manifesto)
        {
            await _context.Manifestos.AddAsync(manifesto);
            await _context.SaveChangesAsync();            
        }
    }
}

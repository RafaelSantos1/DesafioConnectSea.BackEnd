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
    public class ManifestoEscalaRepository : IManifestoEscalaRepository
    {
        private readonly DesafioConnectSeaDbContext _context;
        public ManifestoEscalaRepository(DesafioConnectSeaDbContext context)
        {
            _context = context;
        }
        public async Task<List<ManifestoEscala>> GetAllAsync()
        {
            return await _context.ManifestoEscalas.ToListAsync();
        }
        public async Task AddAsync(ManifestoEscala manifesto)
        {
            try
            {
                await _context.ManifestoEscalas.AddAsync(manifesto);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                 throw new ArgumentException(ex.InnerException.Message);
            }
        }
    }
}

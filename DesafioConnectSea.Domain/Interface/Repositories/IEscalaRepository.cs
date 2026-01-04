using DesafioConnectSea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Domain.Interface.Repositories
{
    public interface IEscalaRepository
    {
        Task<List<Escala>> GetAllAsync();
        Task AddAsync(Escala escala);
    }
}

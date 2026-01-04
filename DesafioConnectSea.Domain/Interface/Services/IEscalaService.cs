using DesafioConnectSea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Domain.Interface.Services
{
    public interface IEscalaService
    {
        Task<List<Escala>> GetAllAsync();
        Task<int> AddAsync(Escala escala);
    }
}

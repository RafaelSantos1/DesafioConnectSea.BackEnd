
using DesafioConnectSea.Domain.Entities;

namespace DesafioConnectSea.Domain.Interface.Services
{
    public interface IManifestoService
    {
        Task<List<Manifesto>> GetAllAsync();
        Task<int> AddAsync(Manifesto manifesto);
    }
}

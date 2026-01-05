
using DesafioConnectSea.Domain.Entities;

namespace DesafioConnectSea.Domain.Interface.Services
{
    public interface IManifestoEscalaService
    {
        Task<List<ManifestoEscala>> GetAllAsync();
        Task<int> AddAsync(ManifestoEscala manifesto);
    }
}

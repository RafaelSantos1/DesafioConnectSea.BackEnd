using AutoMapper;
using DesafioConnectSea.Application.ViewModels;
using DesafioConnectSea.Domain.Entities;
using DesafioConnectSea.Domain.Interface.Repositories;
using DesafioConnectSea.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Application.Services
{
    public class ManifestoService : IManifestoService
    {
        private readonly IManifestoRepository _manifestoRepository;
        public ManifestoService(IManifestoRepository manifestoRepository)
        {
            _manifestoRepository = manifestoRepository;
        }

        public async Task<List<Manifesto>> GetAllAsync()
        {
           return await _manifestoRepository.GetAllAsync();
        }

        public async Task<int> AddAsync(Manifesto manifesto)
        {
            await _manifestoRepository.AddAsync(manifesto);
            return manifesto.Id;
        }
    }
}

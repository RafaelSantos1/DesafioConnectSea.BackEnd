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
    public class ManifestoEscalaService : IManifestoEscalaService
    {
        private readonly IManifestoEscalaRepository _manifestoEscalaRepository;
        private readonly IEscalaRepository _escalaRepository;
        public ManifestoEscalaService(IManifestoEscalaRepository manifestoEscalaRepository, IEscalaRepository escalaRepository)
        {
            _manifestoEscalaRepository = manifestoEscalaRepository;
            _escalaRepository = escalaRepository;
        }

        public async Task<List<ManifestoEscala>> GetAllAsync()
        {
           return await _manifestoEscalaRepository.GetAllAsync();
        }

        public async Task<int> AddAsync(ManifestoEscala manifestoEscala)
        {
            var escala = await _escalaRepository.GetByIdAsync(manifestoEscala.IdEscala);

            if (escala == null) 
                throw new ArgumentException("Escala não encontrada");

            if (escala.Status == Domain.Enums.StatusEnum.Cancelada)
                throw new ArgumentException("Escala cancelada");

            manifestoEscala.DataVinculacao = DateTime.UtcNow;   

            await _manifestoEscalaRepository.AddAsync(manifestoEscala);
            return manifestoEscala.Id;
        }
    }
}

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
    public class EscalaService : IEscalaService
    {
        private readonly IEscalaRepository _escalaRepository;
        public EscalaService(IEscalaRepository escalaRepository)
        {
            _escalaRepository = escalaRepository;
        }       

        public async Task<List<Escala>> GetAllAsync()
        {
            return await _escalaRepository.GetAllAsync();
        }
        public async Task<int> AddAsync(Escala escala)
        {
            await _escalaRepository.AddAsync(escala);
            return escala.Id;
        }
    }
}

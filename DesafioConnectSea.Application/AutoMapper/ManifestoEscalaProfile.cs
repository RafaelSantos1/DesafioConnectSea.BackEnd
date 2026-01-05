using AutoMapper;
using DesafioConnectSea.Application.InputModels;
using DesafioConnectSea.Application.ViewModels;
using DesafioConnectSea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Application.AutoMapper
{
    public class ManifestoEscalaProfile : Profile
    {
        public ManifestoEscalaProfile()
        {
            CreateMap<ManifestoEscala, ManifestoEscalaViewModel>();
            CreateMap<ManifestoEscalaInputModel, ManifestoEscala>();
        } 
    }
}

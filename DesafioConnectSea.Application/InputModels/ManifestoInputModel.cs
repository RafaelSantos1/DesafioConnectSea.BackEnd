using DesafioConnectSea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Application.InputModels
{
    public class ManifestoInputModel
    {
        public string Numero { get; set; }
        public TipoEnum Tipo { get; set; }
        public string Navio { get; set; }
        public string PortoOrigem { get; set; }
        public string PortoDestino { get; set; }
    }
}

using DesafioConnectSea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Application.ViewModels
{
    public class ManifestoViewModel
    {
        public int Id { get; private set; }
        public string Numero { get; private set; }
        public TipoEnum Tipo { get; private set; }
        public string Navio { get; private set; }
        public string PortoOrigem { get; private set; }
        public string PortoDestino { get; private set; }
    }
}

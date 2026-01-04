using DesafioConnectSea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Application.InputModels
{
    public class EscalaInputModel
    {
        public string Navio { get; set; }
        public string Porto { get; set; }
        public EscalaStatusEnum Status { get; set; }
        public DateTime Eta { get; set; }
    }
}

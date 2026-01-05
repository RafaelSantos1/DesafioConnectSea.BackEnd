using DesafioConnectSea.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Application.ViewModels
{
    public class EscalaViewModel
    {
        public int Id { get; private set; }
        public string Navio { get; private set; }
        public string Porto { get; private set; }
        public StatusEnum Status { get; private set; }
        public DateTime Eta { get; private set; }
    }
}


using DesafioConnectSea.Domain.Enums;

namespace DesafioConnectSea.Domain.Entities
{
    public class Escala : BaseEntity
    {
        public string Navio { get; set; }
        public string Porto { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime Eta { get; set; }
    }
}

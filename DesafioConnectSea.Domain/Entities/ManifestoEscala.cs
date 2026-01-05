using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Domain.Entities
{
    public class ManifestoEscala : BaseEntity
    {
        public int IdManifesto { get; set; }

        [ForeignKey("IdManifesto")]
        public Manifesto Manifesto { get; set; }
        public int IdEscala { get; set; }

        [ForeignKey("IdEscala")]
        public Escala Escala { get; set; }

        public DateTime DataVinculacao { get; set; }
    }
}

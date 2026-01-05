using DesafioConnectSea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Infrastructure.Persistence.Configurations
{
    public class ManifestoEscalaConfiguration : IEntityTypeConfiguration<ManifestoEscala>
    {
        public void Configure(EntityTypeBuilder<ManifestoEscala> builder)
        {
            //builder.HasKey(me => new { me.IdManifesto, me.IdEscala });

         
        }      
    
    }
}

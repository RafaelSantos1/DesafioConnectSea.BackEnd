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
    public class ManifestoConfiguration : IEntityTypeConfiguration<Manifesto>
    {
        public void Configure(EntityTypeBuilder<Manifesto> builder)
        {
            builder.HasKey(p => p.Id);            
        }    
    }
}

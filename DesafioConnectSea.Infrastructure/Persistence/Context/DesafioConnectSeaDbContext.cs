using DesafioConnectSea.Domain.Entities;
using DesafioConnectSea.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConnectSea.Infrastructure.Persistence.Context
{
    public class DesafioConnectSeaDbContext : DbContext
    {
        public DesafioConnectSeaDbContext(DbContextOptions<DesafioConnectSeaDbContext> options) : base(options)
        {
        }

        public DbSet<Manifesto> Manifestos { get; set; }
        public DbSet<Escala> Escalas { get; set; }
        public DbSet<ManifestoEscala> ManifestoEscalas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Manifesto>().HasData(
                new Manifesto
                {
                    Id = 1,
                    Numero = "IMP-2025-0001",
                    Tipo = TipoEnum.Importacao,
                    Navio = "MV Atlas",
                    PortoOrigem = "CN SHANGHAI",
                    PortoDestino = "BR SANTOS"
                },
                new Manifesto
                {
                    Id = 2,
                    Numero = "EXP-2025-0042",
                    Tipo = TipoEnum.Exportacao,
                    Navio = "MV Poseidon",
                    PortoOrigem = "BR RIO GRANDE",
                    PortoDestino = "NL ROTTERDAM"
                },
                new Manifesto
                {
                    Id = 3,
                    Numero = "IMP-2025-0099",
                    Tipo = TipoEnum.Importacao,
                    Navio = "MV Hermes",
                    PortoOrigem = "US MIAMI",
                    PortoDestino = "BR SANTOS"
                }
            );

            modelBuilder.Entity<Escala>().HasData(
                new Escala
                {
                    Id = 201,
                    Navio = "MV Atlas",
                    Porto = "BRRGD - RIO GRANDE",
                    Status = StatusEnum.Prevista,
                    Eta = new DateTime(2025, 8, 27, 5, 0, 0)
                },
                new Escala
                {
                    Id = 202,
                    Navio = "MV Atlas",
                    Porto = "BRITJ - ITAJAI",
                    Status = StatusEnum.Cancelada,
                    Eta = new DateTime(2025, 8, 28, 10, 0, 0)
                },
                new Escala
                {
                    Id = 203,
                    Navio = "MV Atlas",
                    Porto = "BRPNG - PARANAGUA",
                    Status = StatusEnum.Prevista,
                    Eta = new DateTime(2025, 8, 29, 21, 0, 0)
                },
                new Escala
                {
                    Id = 204,
                    Navio = "MV Atlas",
                    Porto = "BRSSZ - SANTOS",
                    Status = StatusEnum.Prevista,
                    Eta = new DateTime(2025, 8, 31, 8, 0, 0)
                },
                new Escala
                {
                    Id = 301,
                    Navio = "MV Poseidon",
                    Porto = "BRRGD - RIO GRANDE",
                    Status = StatusEnum.Saiu,
                    Eta = new DateTime(2025, 8, 22, 3, 0, 0)
                },
                new Escala
                {
                    Id = 302,
                    Navio = "MV Poseidon",
                    Porto = "BRITJ - ITAJAI",
                    Status = StatusEnum.Atracada,
                    Eta = new DateTime(2025, 8, 24, 6, 0, 0)
                },
                new Escala
                {
                    Id = 303,
                    Navio = "MV Poseidon",
                    Porto = "BRSSZ - SANTOS",
                    Status = StatusEnum.Prevista,
                    Eta = new DateTime(2025, 8, 26, 9, 0, 0)
                }
            );
        }
    }
}

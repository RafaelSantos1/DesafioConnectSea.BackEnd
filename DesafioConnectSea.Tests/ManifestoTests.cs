using DesafioConnectSea.Application.Services;
using DesafioConnectSea.Domain.Entities;
using DesafioConnectSea.Domain.Enums;
using DesafioConnectSea.Domain.Interface.Repositories;
using DesafioConnectSea.Domain.Interface.Services;
using DesafioConnectSea.Infrastructure.Persistence.Repositories;
using Moq;

namespace DesafioConnectSea.Tests
{
    public class ManifestoTests
    {
        [Fact]
        public async Task GetAllAsync_ReturnsListOfManifestos()
        {
            // Arrange
            var mockRepo = new Mock<IManifestoRepository>();
            mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<Manifesto>
            {
                new Manifesto { Id = 1,Numero = "numero-1", Navio = "Test Manifesto 1", PortoOrigem = "Porto 1", PortoDestino = "Porto 2" },
                new Manifesto { Id = 2,Numero = "numero-2", Navio = "Test Manifesto 2", PortoOrigem = "Porto 3", PortoDestino = "Porto 4" }
            });

            var service = new ManifestoService(mockRepo.Object);

            // Act
            var result = await service.GetAllAsync();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Manifesto>>(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public async Task CreateNewManifesto_ReturnIsOk()
        {
            // Arrange
            var mockRepo = new Mock<IManifestoRepository>();
            var service = new ManifestoService(mockRepo.Object);
            var newManifesto = new Manifesto {
                Numero = "IMP-2025-0001",
                Tipo = TipoEnum.Importacao,
                Navio = "MV Atlas",
                PortoOrigem = "CN SHANGHAI",
                PortoDestino = "BR SANTOS"
            };

            // Act
            var id = await service.AddAsync(newManifesto);

            // Assert
            Assert.True(id >= 0);
            mockRepo.Verify(repo => repo.AddAsync(It.IsAny<Manifesto>()), Times.Once);
        }
    }
}

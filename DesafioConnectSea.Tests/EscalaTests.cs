using DesafioConnectSea.Application.Services;
using DesafioConnectSea.Domain.Entities;
using DesafioConnectSea.Domain.Enums;
using DesafioConnectSea.Domain.Interface.Repositories;
using DesafioConnectSea.Domain.Interface.Services;
using DesafioConnectSea.Infrastructure.Persistence.Repositories;
using Moq;

namespace DesafioConnectSea.Tests
{
    public class EscalaTests
    {
        [Fact]
        public async Task GetAllAsync_ReturnsListOfEscalas()
        {
            // Arrange
            var mockRepo = new Mock<IEscalaRepository>();
            mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<Escala>
            {
                new Escala { Id = 1, Navio = "Test Escala 1" },
                new Escala { Id = 2, Navio = "Test Escala 2" }
            });

            var service = new EscalaService(mockRepo.Object);

            // Act
            var result = await service.GetAllAsync();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Escala>>(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public async Task CreateNewEscala_ReturnIsOk()
        {
            // Arrange
            var mockRepo = new Mock<IEscalaRepository>();
            var service = new EscalaService(mockRepo.Object);
            var newEscala = new Escala {
                Navio = "MV Explorer",
                Porto = "BR RIO DE JANEIRO",
                Status = StatusEnum.Atracada,
                Eta = DateTime.UtcNow.AddDays(3)
            };

            // Act
            var id = await service.AddAsync(newEscala);

            // Assert
            Assert.True(id >= 0);
            mockRepo.Verify(repo => repo.AddAsync(It.IsAny<Escala>()), Times.Once);
        }
    }
}

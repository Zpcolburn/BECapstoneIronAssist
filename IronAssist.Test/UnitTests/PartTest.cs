using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Moq;
using Xunit;

namespace IronAssist.Test.UnitTests
{
    public class PartServiceTest
    {
        private readonly Mock<IPartRepository> _mockPartRepository;
        private readonly PartService _partService;

        public PartServiceTest()
        {
            _mockPartRepository = new Mock<IPartRepository>();
            _partService = new PartService(_mockPartRepository.Object);
        }

        [Fact]
        public async Task GetAllPartAsync_ShouldReturnListOfParts()
        {
            // Arrange
            var parts = new List<Part>
            {
                new Part { Id = 1, Name = "Part1", Description = "Description1", PartNumber = "P001", Quantity = 10, Price = 100, Location = "Shelf1" },
                new Part { Id = 2, Name = "Part2", Description = "Description2", PartNumber = "P002", Quantity = 20, Price = 200, Location = "Shelf2" }
            };

            _mockPartRepository.Setup(repo => repo.GetAllPartAsync()).ReturnsAsync(parts);

            // Act
            var result = await _partService.GetAllPartAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("Part1", result[0].Name);
        }

        [Fact]
        public async Task GetSinglePartAsync_ShouldReturnPartById()
        {
            // Arrange
            var part = new Part { Id = 1, Name = "Part1", Description = "Description1", PartNumber = "P001", Quantity = 10, Price = 100, Location = "Shelf1" };

            _mockPartRepository.Setup(repo => repo.GetSinglePartAsync(part.Id)).ReturnsAsync(part);

            // Act
            var result = await _partService.GetSinglePartAsync(part.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(part.Id, result.Id);
            Assert.Equal("Part1", result.Name);
        }

        [Fact]
        public async Task AddPartAsync_ShouldAddAndReturnPart()
        {
            // Arrange
            var newPart = new Part { Id = 1, Name = "NewPart", Description = "NewDescription", PartNumber = "P003", Quantity = 5, Price = 50, Location = "Shelf3" };

            _mockPartRepository.Setup(repo => repo.AddPartAsync(newPart)).ReturnsAsync(newPart);

            // Act
            var result = await _partService.AddPartAsync(newPart);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(newPart.Id, result.Id);
            Assert.Equal("NewPart", result.Name);
        }

        [Fact]
        public async Task UpdateSinglePartAsync_ShouldUpdateAndReturnUpdatedPart()
        {
            // Arrange
            var existingPart = new Part { Id = 1, Name = "OldPart", Description = "OldDescription", PartNumber = "P003", Quantity = 5, Price = 50, Location = "Shelf3" };
            var updatedPart = new Part { Id = 1, Name = "UpdatedPart", Description = "UpdatedDescription", PartNumber = "P003", Quantity = 10, Price = 100, Location = "Shelf3" };

            _mockPartRepository.Setup(repo => repo.UpdateSinglePartAsync(existingPart.Id, updatedPart)).ReturnsAsync(updatedPart);

            // Act
            var result = await _partService.UpdateSinglePartAsync(existingPart.Id, updatedPart);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("UpdatedPart", result.Name);
            Assert.Equal(10, result.Quantity);
        }

        [Fact]
        public async Task DeleteSinglePartAsync_ShouldDeleteAndReturnPart()
        {
            // Arrange
            var part = new Part { Id = 1, Name = "PartToDelete", Description = "ToDelete", PartNumber = "P004", Quantity = 0, Price = 0, Location = "Shelf4" };

            _mockPartRepository.Setup(repo => repo.DeleteSinglePartAsync(part.Id)).ReturnsAsync(part);

            // Act
            var result = await _partService.DeleteSinglePartAsync(part.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(part.Id, result.Id);
            Assert.Equal("PartToDelete", result.Name);
        }
    }
}
